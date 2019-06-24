using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMBAM_Project
{
    public partial class OrderDisplay : Form
    {
        public delegate void OrderHandler(object sender, Table args);
        public delegate void PayHandler(object sender, Table args);
        public event OrderHandler OnOrderComplete;
        public event PayHandler OnPayComplete;

        Table tableInfo = new Table();
        MenuData menudata = new MenuData();
        int imageindex = 0;
        private string barcodeString = string.Empty;

        public OrderDisplay(Table table)
        {
            InitializeComponent();
            tableInfo = table;
            OrderTime.Text = table.OrderDateTime;
            Form_Setting();
            Addhandler();
            SetInfoByClickTable(table);
        }

        private void Form_Setting()
        {
            NumTable.TextAlign = ContentAlignment.MiddleRight;
            NumTable.Text = tableInfo.TableNumber + "번째 테이블";
            Allprice.TextAlign = ContentAlignment.MiddleRight;
            Allprice.Text = "0원";
            NowTimer.Start();
        }

        private void Addhandler()
        {
            Kimbab.Click += Category_Click;
            Dongas.Click += Category_Click;
            Food.Click += Category_Click;
            Bunsic.Click += Category_Click;
            side.Click += Category_Click;
            MainBtn.Click += Mainbtn_Click;
            Cancel.Click += RemoveMenuItem;
            AllCancel.Click += RemoveAllMenuItem;
            plus.Click += PlusCountMenu;
            minus.Click += MinusCountMenu;
            BuyBtn.Click += Paybtn_Click;
            Order_btn.Click += Orderbtn_Click;
        }

        private void UpdateMenuItem(String name)
        {
            Menu selectMenuData = menudata.GetMenuByName(name);
            foreach (ListViewItem item in OrderMenu.Items)
            {
                if (item.SubItems[0].Text.Equals(name))
                {
                    int SelectCount = int.Parse(item.SubItems[1].Text)+1;
                    item.SubItems[1].Text = SelectCount.ToString();

                    int SelectPrice = selectMenuData.price;
                    item.SubItems[2].Text = (SelectCount * SelectPrice).ToString();

                    SetToTalPrice();
                    return;
                }
            }
            AddMenuItem(selectMenuData);
        }   //선택한 메뉴 주문리스트에 추가(중복)

        private void AddMenuItem(Menu menu)
        {
            ListViewItem item = new ListViewItem(menu.name);
            item.SubItems.Add(menu.count.ToString());
            item.SubItems.Add(menu.price.ToString());
            OrderMenu.Items.Add(item);
            SetToTalPrice();
        }   //주문리스트에 메뉴가 없을 시 메뉴추가

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            this.ActiveControl = null;
            if (msg.Msg == 0x100)
            {
                string log = string.Format("ProcessCmdKey KeyData: {0}", keyData);
                if (keyData == Keys.Return)
                {
                    Menu menu = menudata.GetMenuByBarcode(barcodeString);
                    if (menu != null)
                    {
                        SetMenuImage(menu);
                        UpdateMenuItem(menu.name);
                    }
                    barcodeString = string.Empty;
                }
                else
                {
                    barcodeString += char.ConvertFromUtf32((int)keyData);
                }

                Debug.WriteLine(log);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RemoveMenuItem(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.OrderMenu.SelectedIndices;
            if(indexes.Count > 0)
            {
                ListViewItem item = OrderMenu.SelectedItems[0];
                OrderMenu.Items.Remove(item);
                SetToTalPrice();
            }
        }

        private void RemoveAllMenuItem(object sender, EventArgs e)
        {
            OrderMenu.Items.Clear();
            SetToTalPrice();
        }

        private void PlusCountMenu(object sender, EventArgs e)
        {
            
            ListView.SelectedIndexCollection indexes = this.OrderMenu.SelectedIndices;
            if (indexes.Count > 0)
            {
                String name = OrderMenu.SelectedItems[0].SubItems[0].Text;
                int count = int.Parse(OrderMenu.SelectedItems[0].SubItems[1].Text) + 1;
                OrderMenu.SelectedItems[0].SubItems[1].Text = count.ToString();
                int price = menudata.GetPriceByName(name);
                OrderMenu.SelectedItems[0].SubItems[2].Text = (count*price).ToString();
                SetToTalPrice();
            }
        }

        private void MinusCountMenu(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.OrderMenu.SelectedIndices;
            if (indexes.Count > 0)
            {
                String name = OrderMenu.SelectedItems[0].SubItems[0].Text;
                int count = int.Parse(OrderMenu.SelectedItems[0].SubItems[1].Text) - 1;
                OrderMenu.SelectedItems[0].SubItems[1].Text = count.ToString();
                if(count == 0)
                {
                    ListViewItem item = OrderMenu.SelectedItems[0];
                    OrderMenu.Items.Remove(item);
                    SetToTalPrice();
                    return;
                }
                int price = menudata.GetPriceByName(name);
                OrderMenu.SelectedItems[0].SubItems[2].Text = (count * price).ToString();
                SetToTalPrice();
            }
        }

        private void SetToTalPrice()
        {
            int Totalprice = 0;
            if (OrderMenu.Items.Count == 0)
            {
                Allprice.Text = Totalprice.ToString() + "원";
                return;
            }
            foreach (ListViewItem item in OrderMenu.Items)
            {
                Totalprice += int.Parse(item.SubItems[2].Text);
                Allprice.Text = Totalprice.ToString() + "원";
            }

        }

        private void SetPayment()
        {
            if(Card.Checked == true)
            {
                tableInfo.PaymentMethod = "카드";
            }else if(Money.Checked == true)
            {
                tableInfo.PaymentMethod = "현금";
            }
        }

        private void SetInfoByClickTable(Table table)
        {
            if (table.MenuInfo != null)
            {
                foreach (Menu menu in table.MenuInfo)
                {
                    AddMenuItem(menu);
                }
            }
        }   //클릭한 테이블의 주문정보가 있으면 가져오기

        private void SetMenuByOrder()
        {
            List<Menu> Orderlist = new List<Menu>();

            foreach (ListViewItem item in OrderMenu.Items)
            {
                Menu menu = new Menu(item.SubItems[0].Text, int.Parse(item.SubItems[2].Text),
                    menudata.GetCategoryByName(item.SubItems[0].Text), int.Parse(item.SubItems[1].Text), "");
                Orderlist.Add(menu);
            }

            tableInfo.MenuInfo = Orderlist;
            tableInfo.OrderDateTime = System.DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh시 mm분 ss초");
        }

        private void SetMenuImage(Menu menu)
        {
            foreach (Menu item in menudata.listmenu)
            {
                if (item.name == menu.name)
                {
                    MenuImage.Image = Image.FromFile(menu.path);
                }
            }
        }

        private void SetlstMenuItem(Menu menu)
        {
            MenuItemImage.Images.Add(menu.name, Image.FromFile(menu.path));
            lstMenuitem.Items.Add(menu.name, imageindex);
            imageindex++;
        }

        private void ImageSetting()
        {
            lstMenuitem.Items.Clear();
            MenuItemImage.Images.Clear();
            MenuItemImage.ImageSize = new Size(200, 200);
            lstMenuitem.LargeImageList = MenuItemImage;
            imageindex = 0;
        }

        private DialogResult GetMessageByPay()
        {
            if (Card.Checked == false && Money.Checked == false)
            {
                MessageBox.Show("결제방법을 선택해주세요.", "결제방법", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult;
            }
            String message = "";
            foreach (ListViewItem item in OrderMenu.Items)
            {
                message += item.SubItems[0].Text + " 수량 " + item.SubItems[1].Text + "\n";
            }
            SetPayment();
            message += "총 합계 : " + Allprice.Text + "\n결제방법 : " + tableInfo.PaymentMethod;
            DialogResult result;
            result = MessageBox.Show(message, "결제", MessageBoxButtons.YesNo);
            return result;
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {

            SetMenuByOrder(); 
            
            if (OnOrderComplete != null)
            {
                OnOrderComplete(this, tableInfo); //메인화면 이동(주문 이후)
                this.Close();
            }
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            if (GetMessageByPay() == System.Windows.Forms.DialogResult.Yes)
            {
                SetPayment();
                if (OnOrderComplete != null)
                {
                    OrderMenu.Items.Clear();
                    //메인화면 이동(결제 이후)
                    if (OnPayComplete != null)
                    {
                        OnPayComplete(this, tableInfo);
                        this.Close();
                    }
                }
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if(lstMenuitem.SelectedItems.Count < 0)
            {
                return;
            }
            ListView.SelectedIndexCollection indexes = this.lstMenuitem.SelectedIndices;
            foreach (int index in indexes)
            {
                string menuName = lstMenuitem.Items[index].Text;
                SetMenuImage(menudata.GetMenuByName(menuName));
                UpdateMenuItem(lstMenuitem.Items[index].Text);
            }
            this.lstMenuitem.SelectedItems.Clear();
        }

        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void Category_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ImageSetting();
            foreach (var menu in menudata.listmenu)
            {
                if (menu.category.Equals(button.Text))
                {
                    SetlstMenuItem(menu);
                }
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            ImageSetting();
            foreach (var menu in menudata.listmenu)
            {
                SetlstMenuItem(menu);
            }
        }
         
        private void NowTimer_Tick(object sender, EventArgs e)
        {
            NowTime.Text = System.DateTime.Now.ToString("현재시간 : yyyy년 MM월 dd일 tt hh시 mm분 ss초");
        }

    }

}

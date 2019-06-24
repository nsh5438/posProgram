using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMBAM_Project
{
    public partial class MainDisplay : Form
    {
        public int memuTable_cnt=0;
        Table table = new Table();
        List<Table> lstTable = new List<Table>();
        List<ListBox> lstListbox = new List<ListBox>();
        List<Table> lstStat = new List<Table>();

        public MainDisplay()
        {
            InitializeComponent();
            AddTableInList();
            Addhandler();
            lbDate.Text = System.DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh시 mm분");
        }

        private void Addhandler()
        {
            OrderTable1.Click += Table_Click;
            OrderTable2.Click += Table_Click;
            OrderTable3.Click += Table_Click;
            OrderTable4.Click += Table_Click;
            OrderTable5.Click += Table_Click;
            OrderTable6.Click += Table_Click;
        }   //버튼 클릭시 실행 

        private void ClearTable(Table table)
        {
            ListBox SelectOrderTable = GetTable(table);
            SelectOrderTable.Items.Clear();
            table.MenuInfo.Clear(); 
        }

        private void UpdateTable(Table table)
        {
            ListBox SelectOrderTable = GetTable(table);
            SetOrderList(SelectOrderTable, table);
        }

        private void SetOrderList(ListBox listBox, Table table)
        {
            ListBox lbox = GetTable(table);
            lbox.Items.Clear();
            foreach (Menu menu in table.MenuInfo)
            {
                listBox.Items.Add(menu.name + " " + menu.count);
                SetTableInfo(table);
            }
        }    //테이블에 주문정보 넣기

        private void SetTableInfo(Table table)
        {
            foreach (Table tableInfo in lstTable)
            {
                if (tableInfo.TableNumber.ToString().Equals(table.TableNumber))
                {
                    tableInfo.MenuInfo = table.MenuInfo;
                }
            }
        }    //테이블 리스트에 해당 테이블 정보 넣기

        private ListBox GetTable(Table table)
        {
            foreach (ListBox listBox in lstListbox)
            {
                if (listBox.Tag.ToString().Equals(table.TableNumber))
                {
                    return listBox;
                }
            }
            return null;
        }   

        private Table GetInfoByClickTable(ListBox listbox)
        {
            foreach (Table tableinfo in lstTable)
            {
                if (tableinfo.TableNumber == listbox.Tag.ToString())
                {
                    return tableinfo;
                }
            }
            return null;
        }   

        private void AddTableInList()
        {
            AddListBoxInList();
            foreach (ListBox listbox in lstListbox)
            {
                Table table = new Table();
                table.TableNumber = listbox.Tag.ToString();
                lstTable.Add(table); 
            }
        }    //테이블 리스트에 테이블 추가

        private void AddListBoxInList()
        {
            for(int i= 1; i <= 6; i++)
            {
                ListBox lstbox = new ListBox();
                lstbox = (ListBox)this.Controls.Find("OrderTable" + i, true).FirstOrDefault();
                lstListbox.Add(lstbox);
            }
        }   //리스트에 모든 테이블 추가

        private void BtnStat_Click(object sender, EventArgs e)
        {
            StatDisplay stat = new StatDisplay(lstStat);
            stat.FormClosed += Order_FormClosed;
            stat.Show();
            this.Hide();
        }   

        private void Table_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            memuTable_cnt = int.Parse(listBox.Tag.ToString());
            Table ClickTableInfo = GetInfoByClickTable(listBox);
            OrderForm_Open(ClickTableInfo);
        }   

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void OrderForm_Open(Table ClickTableInfo)
        {
            OrderDisplay order = new OrderDisplay(ClickTableInfo);
            order.OnOrderComplete += Order_OnOrderComplete;
            order.OnPayComplete += Order_OnPayComplete;
            order.FormClosed += Order_FormClosed;
            order.Show();
            this.Hide();
        }

        private void Order_OnOrderComplete(object sender, Table table)
        {
            AddTableInList();
            UpdateTable(table);
        }

        private void Order_OnPayComplete(object sender, Table table)
        {
            Table item = new Table();
            item.TableNumber = table.TableNumber;
            item.OrderDateTime = table.OrderDateTime;
            item.PaymentMethod = table.PaymentMethod;
            item.MenuInfo = new List<Menu>();

            if(table.MenuInfo != null)
            {
                foreach (Menu menu in table.MenuInfo)
                {
                    item.MenuInfo.Add(menu);
                }
                lstStat.Add(item);
                ClearTable(table);
            }
            else
            {
                MessageBox.Show("주문부터 해주세요.\n메인폼으로 이동합니다.", "결제오류", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            
        }


    }


}

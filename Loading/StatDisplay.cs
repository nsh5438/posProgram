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
    public partial class StatDisplay : Form
    {
        List<Menu> lstMenu = new List<Menu>();
        List<Table> table = new List<Table>();

        public StatDisplay(List<Table> tablestat)
        {
            InitializeComponent();
            category_stat.Items.Clear();
            this.table = tablestat;
            AddMenuInList();
            SetStatDisplay();
        }
        private void AddMenuInList()
        {
            foreach(Table table in this.table)
            {
                if(table != null)
                {
                    foreach(Menu menu in table.MenuInfo)
                    {
                        lstMenu.Add(menu);
                    }
                }
            }
        }

        private void StatByCategory()
        {
            foreach (Menu menu in lstMenu)
            {
                List<Menu> category_menu = lstMenu.Where(x => x.category == menu.category).ToList();
                String category = category_menu[0].category;
                SetStatData(category_menu, category, category_stat, menu);
            }
        }   //카테고리통계

        private void StatByMenuName()
        {
            foreach (Menu menu in lstMenu)
             {
                List<Menu> menunames = lstMenu.Where(x => x.name == menu.name).ToList();
                SetStatData(menunames, menunames[0].name, Menu_stat, menu);
            }
        }   //메뉴별통계

        private void StatByPayment()
        {
            foreach (Table table in this.table)
            {
                if (table != null)
                {
                    foreach (Menu menu in table.MenuInfo)
                    {
                        ListViewItem exititem = GetPaymentByList(table);
                        if (exititem != null)
                        {
                            int price = Int32.Parse(exititem.SubItems[1].Text);
                            price += menu.price;
                            exititem.SubItems[1].Text = price.ToString();
                        }
                        else
                        {
                            ListViewItem item = new ListViewItem(table.PaymentMethod);
                            item.SubItems.Add(menu.price.ToString());
                            pay_stat.Items.Add(item);
                        }
                    }
                }
            }
        }   //결제방법별 통계

        private void SetStatData(List<Menu> lstmenu, String firstrow, ListView lstview, Menu menu) 
        {
            ListViewItem exititem = GetItemByListView(lstview, lstmenu);

            if (exititem != null)
                UpdateStatData(exititem, menu);
            else
                AddStatData(menu, lstview, firstrow);

        }    //통계데이터설정

        private void SetStatDisplay()
        {
            StatByCategory();
            StatByMenuName();
            StatByPayment();
        }

        private void AddStatData(Menu menu, ListView listview, String firstrow)
        {
            ListViewItem item = new ListViewItem(firstrow);
            item.SubItems.Add(menu.count.ToString());
            item.SubItems.Add(menu.price.ToString());
            listview.Items.Add(item);
        }

        private void UpdateStatData(ListViewItem item, Menu menu)
        {
            int count = Int32.Parse(item.SubItems[1].Text);
            int price = Int32.Parse(item.SubItems[2].Text);
            count += menu.count;
            price += menu.price;
            item.SubItems[1].Text = count.ToString();
            item.SubItems[2].Text = price.ToString();
        }

        private ListViewItem GetItemByListView(ListView listview, List<Menu> menu)
        {
            ListViewItem exititem = null;
            if (listview == category_stat)
                exititem = GetCategoryByList(menu);
            else
                exititem = GetNameByList(menu);
            return exititem;
        }   //리스트뷰에 데이터 존재여부 체크

        private ListViewItem GetCategoryByList(List<Menu> category_menu)
        {
            foreach(ListViewItem item in category_stat.Items)
            {
                if(item.SubItems[0].Text == category_menu[0].category)
                {
                    return item;
                }
            }
            return null;
        }   //리스트뷰에 카테고리 존재여부

        private ListViewItem GetNameByList(List<Menu> menuname_menu)
        {
            foreach (ListViewItem item in Menu_stat.Items)
            {
                if (item.SubItems[0].Text == menuname_menu[0].name)
                {
                    return item;
                }
            }
            return null;
        }    //리스트뷰에 메뉴이름 존재여부

        private ListViewItem GetPaymentByList(Table table)
        {
            foreach(ListViewItem item in pay_stat.Items)
            {
                if(item.SubItems[0].Text == table.PaymentMethod)
                {
                    return item;
                }
            }
            return null;
        }        //리스트뷰에 결제방법 존재여부


    }
}

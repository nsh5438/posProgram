using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIMBAM_Project
{
    public class MenuData
    {
        public List<Menu> listmenu = new List<Menu>();

        public MenuData()
        {
            listmenu.Add(new Menu("고봉민김밥",2500, "김밥류", 1,"1"));
            listmenu.Add(new Menu("돈까스김밥", 3500, "김밥류", 1, "1"));
            listmenu.Add(new Menu("떡갈비김밥", 3500, "김밥류", 1, "1"));
            listmenu.Add(new Menu("맵닭김밥", 2800, "김밥류", 1, "1"));
            listmenu.Add(new Menu("새우김밥", 3500, "김밥류", 1, "1"));
            listmenu.Add(new Menu("소불고기김밥", 3800, "김밥류", 1, "1"));
            listmenu.Add(new Menu("와사비어묵김밥", 3800, "김밥류", 1, "1"));
            listmenu.Add(new Menu("참치김밥", 3500, "김밥류", 1, "1"));
            listmenu.Add(new Menu("치즈김밥", 3500, "김밥류", 1, "1"));

            listmenu.Add(new Menu("우동", 4500, "분식류", 1, "1"));
            listmenu.Add(new Menu("떡볶이", 5500, "분식류", 1, "1"));
            listmenu.Add(new Menu("손수제비", 5000, "분식류", 1, "1"));
            listmenu.Add(new Menu("신라면", 4000, "분식류", 1, "1"));
            listmenu.Add(new Menu("잔치국수", 6500, "분식류", 1, "1"));
            listmenu.Add(new Menu("쫄면", 6000, "분식류", 1, "1"));

            listmenu.Add(new Menu("고구마치즈돈까스", 10000, "돈가스류", 1, "1"));
            listmenu.Add(new Menu("고봉민돈까스", 8500, "돈가스류", 1, "1"));
            listmenu.Add(new Menu("치즈돈까스", 9500, "돈가스류", 1, "1"));

            listmenu.Add(new Menu("고상한쌈", 7400, "식사류", 1, "1"));
            listmenu.Add(new Menu("마파통두부덮밥", 7500, "식사류", 1, "1"));
            listmenu.Add(new Menu("순두부찌개", 7800, "식사류", 1, "1"));
            listmenu.Add(new Menu("육개장한상", 7900, "식사류", 1, "1"));

            listmenu.Add(new Menu("코카콜라", 2000, "음료", 1, "8801094017200"));
            listmenu.Add(new Menu("펩시", 2000, "음료", 1, "8801056070809"));
        }

        //선택한 메뉴 데이터 가져오기
        public Menu GetMenuByName(String name)
        {
            foreach (Menu item in listmenu)
            {
                if (item.name == name)
                {
                    return item;
                }
            }
            return null;

        }

        public Menu GetMenuByBarcode(String barcode)
        {
            foreach (Menu item in listmenu)
            {
                if (item.barcode == barcode)
                {
                    return item;
                }
            }
            return null;
        }

        public int GetPriceByName(String name)
        {
            foreach (Menu item in listmenu)
            {
                if (item.name == name)
                {
                    return item.price;
                }
            }
            return -1;
        }

        public String GetCategoryByName(String name)
        {
            foreach (Menu item in listmenu)
            {
                if (item.name == name)
                {
                    return item.category;
                }
            }
            return "";
        }
    }
}

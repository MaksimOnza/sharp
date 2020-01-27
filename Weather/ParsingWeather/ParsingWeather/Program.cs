using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using ThirdParty.Json.LitJson;

namespace ParsingWeather
{
    class Menu
    {

        public List<Object> items;
        public string key = "";
        public Menu()
        {
        }
        public void start(List<Object> items)
        {
            foreach (Object item in items)
            {
                ItemTest it = (ItemTest)item;
                Console.WriteLine(it.name);
            }
            key = Console.ReadLine();
            foreach (Object item in items)
            {
                if (key == "1") { }
                ItemTest it = (ItemTest)item;
                Console.WriteLine(it.name);
            }

            Console.ReadKey();
        }
    }
    class ItemTest
    {
        public string name = "ItemTest";
    }
    class ItemTest2: ItemTest
    {
        public string name = "ItemTest2222";
        ItemTest test1 = new ItemTest();
        ItemTest2 test2 = new ItemTest2();
        List<Object> l ;
        public void start()
        {
            var sMenu = new Menu();
            l = new List<object>() { test1, test1 };
            sMenu.start(l);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ItemTest test1 = new ItemTest();
            ItemTest2 test2 = new ItemTest2();
            List<Object> l = new List<object>() { test2 , test2 };
            var mv = new Menu();
            List<Object> el = new List<object>() { test1, mv };

            var m = new Menu();
            m.start(l);
                /*var webSelect1 = new WebItem1();
            var webSelect2 = new WebItem2();
            var webSelect3 = new WebItem3();
            ArrayList web = new ArrayList();
            web.Add(webSelect1);
            web.Add(webSelect2);
            web.Add(webSelect3);

            var ssss = new Menu() { webSelect2, web, webSelect1, webSelect3 };

            Menu menu = new Menu(ssss);
            menu.start();*/
        }

    }
}

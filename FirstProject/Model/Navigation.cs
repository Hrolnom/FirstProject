using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FirstProject.Model
{
    internal class Navigation
    {
        public static bool IsAutorizate = false;
        public static MainWindow main;
        public static List<Nav> navs = new List<Nav>();
        public static void NextPage(Nav nav)
        {
            navs.Add(nav);
            Update(nav);
        }
        public static void BackPage()
        {
            if (navs.Count > 1)
            {
                navs.Remove(navs[navs.Count - 1]);
                Update(navs[navs.Count - 1]);
            }
        }
        private static void Update(Nav nav)
        {
            main.TitleTb.Text = nav.Title;
            main.BackBtn.Visibility = navs.Count() > 2 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
            main.ExitBtn.Visibility = IsAutorizate ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
            main.MyFrame.Navigate(nav.Page);

        }
    }

    class Nav
    {
        public string Title { get; set; }
        public Page Page { get; set; }
        public Nav(string Title, Page Page)
        {
            this.Title = Title;
            this.Page = Page;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoxyOkienka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            log_blc.Text += ("Start programu... Wylosuj boxy...\n");
            howMuch_box.Focus();
        }


        private void draw_btn_Click(object sender, RoutedEventArgs e) => log_blc.Text += Box.CreateBox(Convert.ToInt32(howMuch_box.Text));

        private void search_btn_Click(object sender, RoutedEventArgs e) => log_blc.Text += Box.SearchBox();

        private void all_boxes_Click(object sender, RoutedEventArgs e) => all_blc.Text = Box.ShowBox();

        private void about_btn_Click(object sender, RoutedEventArgs e)
        {
            about About_window = new about();
            About_window.ShowDialog();
        }

        private void close_btn_Click(object sender, RoutedEventArgs e) => Close();
    }
}

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

namespace Human
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();
        private Classes.Russian Russian = new Classes.Russian("Ирина", @"C:\Users\Student-A502.PERMAVIAT\Desktop\Human\Human\Images\ic_russian.png");
        private Classes.English English = new Classes.English("Irina", @"C:\Users\Student-A502.PERMAVIAT\Desktop\Human\Human\Images\ic_english.png");
        public MainWindow()
        {
            InitializeComponent();
            parent.Children.Add(new Elements.Item(Russian));
            parent.Children.Add(new Elements.Item(English));
        }
    }
}

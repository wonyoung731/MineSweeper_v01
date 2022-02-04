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
using System.Windows.Shapes;

namespace MineSweeper
{
    /// <summary>
    /// Option.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Option : Window
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Okay_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("적용되었습니다.");

            MainWindow mainWindow = new MainWindow();
        }
    }
}

using CefSharp.Wpf;
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

namespace SmartAssistant
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser();
        public MainWindow()
        {
            InitializeComponent();
            CefContainer.Children.Add(chromiumWebBrowser);
            chromiumWebBrowser.Address = "https://www.baidu.com";
        }
    }
}

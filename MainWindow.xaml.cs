using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
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
using Wpf.SQLite.Teste.Model;

namespace Wpf.SQLite.Teste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyDBContext context = new MyDBContext();
            context.Users.OrderBy(c => c.FirstName).Load();
            this.dataGrid.ItemsSource = context.Users.Local;
        }
    }
}

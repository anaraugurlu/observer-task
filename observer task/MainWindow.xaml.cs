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

namespace observer_task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Store Store { get; set; } = new Store();
        public EmailCustomer  Customer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Store.Customers = new List<ICustomer>();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Store.Customers.Add(Customer = new EmailCustomer {  Name = name.Text ,Email2 =email .Text  });
           
            MessageBox.Show("Customer was added");
        }

        private void notify_Click(object sender, RoutedEventArgs e)
        {
            Store.Notify();
            MessageBox.Show("You have message in your gmail box");
        }
    }
}

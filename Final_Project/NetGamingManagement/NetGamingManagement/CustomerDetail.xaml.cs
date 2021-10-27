using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NetGamingManagement
{
    /// <summary>
    /// Interaction logic for CustomerDetail.xaml
    /// </summary>
    public partial class CustomerDetail : Window
    {
        public CustomerDetail(ICloseable context)
        {
            InitializeComponent();
            context.CloseRequest += (s, e) => this.Close();
        }
    }
}

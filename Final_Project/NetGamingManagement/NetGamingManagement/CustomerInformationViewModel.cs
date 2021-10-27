using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetGamingManagement
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Account { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class CustomerInformationViewModel : BaseViewModel
    {
        private string m_searchKeyword;
        public string SearchKeyword
        {
            get => m_searchKeyword;
            set
            {
                m_searchKeyword = value;
                OnPropertyChanged(nameof(SearchKeyword));
            }
        }

        private Customer m_selectedCustomer;
        public Customer SelectedCustomer
        {
            get => m_selectedCustomer;
            set
            {
                m_selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }
        }
        public ObservableCollection<Customer> Customers { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }

        private ICustomerService m_customerSrv;

        public CustomerInformationViewModel()
        {
            m_customerSrv = new CustomerServiceWithEF();
            Customers = new ObservableCollection<Customer>(m_customerSrv.SearchCustomer(string.Empty));

            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
            SearchCommand = new ConditionalCommand(x => DoSearch());
            ResetCommand = new ConditionalCommand(x => DoReset());
        }

        public void DoOpenDetail()
        {
            m_customerSrv = new CustomerServiceWithEF();
            var CustomerDetailViewModel = new CustomerDetailViewModel(m_customerSrv, SelectedCustomer.CustomerId);
            CustomerDetail customerDetail = new CustomerDetail(CustomerDetailViewModel);
            customerDetail.DataContext = CustomerDetailViewModel;
            customerDetail.ShowDialog();
        }

        public void DoReset()
        {
            SearchKeyword = null;
        }

        private void DoSearch()
        {
            Customers.Clear();
            var result = m_customerSrv.SearchCustomer(SearchKeyword);
            foreach (var s in result)
            {
                Customers.Add(s);
            }
        }
    }
}

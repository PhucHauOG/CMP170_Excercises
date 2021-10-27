using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NetGamingManagement.CustomerDetailViewModel;

namespace NetGamingManagement
{
    public class CustomerDetailViewModel : BaseViewModel, ICloseable
    {
        private int customerId;
        private string firstname;
        private string lastname;
        private string accountdetail;
        private string email;
        private string phone;

        public int CustomerIdDetail
        {
            get => customerId; set
            {
                customerId = value;
                OnPropertyChanged(nameof(CustomerIdDetail));
            }
        }

        public String FirstNameDetail
        {
            get => firstname;
            set
            {
                firstname = value;
                OnPropertyChanged(nameof(FirstNameDetail));
            }
        }
        public String LastNameDetail
        {
            get => lastname;
            set
            {
                lastname = value;
                OnPropertyChanged(nameof(LastNameDetail));
            }
        }

        public String AccountDetail { get => accountdetail; set => accountdetail = value; }
        public String EmailDetail { get => email; set => email = value; }
        

        public String PhoneDetail
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged(nameof(PhoneDetail));
            }
        }

        public ConditionalCommand SaveCommand { get; }
        public ConditionalCommand CancelCommand { get; }

        private ICustomerService m_customerService;
        public CustomerDetailViewModel(ICustomerService customerService, int customerId)
        {
            m_customerService = customerService;

            var customer = m_customerService.LoadCustomerById(customerId);
            CustomerIdDetail = customer.CustomerId;
            FirstNameDetail = customer.FirstName;
            LastNameDetail = customer.LastName;
            AccountDetail = customer.Account;
            EmailDetail = customer.Email;
            PhoneDetail = customer.Phone;

            SaveCommand = new ConditionalCommand(x => DoSave(customerId));
            CancelCommand = new ConditionalCommand(x => DoCancel());
        }

        private void DoSave(int id)
        {
            var m_customer = m_customerService.LoadCustomerById(id);
            m_customer.CustomerId = CustomerIdDetail;
            m_customer.FirstName = FirstNameDetail;
            m_customer.LastName = LastNameDetail;
            m_customer.Email = EmailDetail;
            m_customer.Account = AccountDetail;
            m_customerService.UpdateOrCreateCustomer(m_customer); ;
        }
        public event EventHandler CloseRequest;
        protected void DoCancel()
        {
            var handler = CloseRequest;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}

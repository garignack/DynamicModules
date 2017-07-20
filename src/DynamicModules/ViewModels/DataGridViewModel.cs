using System.Collections.ObjectModel;
using Prism.Mvvm;
using VTX.Core.Model;
using VTX.Core.Services;

namespace VTX.Base.ViewModels
{
    public class DataGridViewModel : BindableBase
    {
        private ObservableCollection<Customer> customers;
        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { SetProperty(ref customers, value); }
        }

        public DataGridViewModel(ICustomerService service)
        {
            Customers = new ObservableCollection<Customer>();
            Customers.AddRange(service.GetAllCustomers());
        }
    }
}

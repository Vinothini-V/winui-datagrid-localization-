using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    public class ViewModel : Microsoft.UI.Xaml.Data.INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            for (int i = 0; i < 3; i++)
            {
                _orders.Add(new OrderInfo() { OrderID = 1001, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", UnitPrice = 107.00, IsDelivered = true }); ;
                _orders.Add(new OrderInfo() { OrderID = 1002, CustomerName = "Ana Trujilo", Country = "Mexico", CustomerID = "ANATR", UnitPrice = 360.00, IsDelivered = false });
                _orders.Add(new OrderInfo() { OrderID = 1003, CustomerName = "Antonio Moreno", Country = "Mexico", CustomerID = "ANTON", UnitPrice = 400.40, IsDelivered = true });
                _orders.Add(new OrderInfo() { OrderID = 1004, CustomerName = "Thomas Hardy", Country = "UK", CustomerID = "AROUT", UnitPrice = 107.00, IsDelivered = true });
                _orders.Add(new OrderInfo() { OrderID = 1005, CustomerName = "Christina Berglund", Country = "Sweden", CustomerID = "BERGS", UnitPrice = 203.00, IsDelivered = true });
                _orders.Add(new OrderInfo() { OrderID = 1006, CustomerName = null, Country = "Germany", CustomerID = "BLAUS", UnitPrice = null, IsDelivered = false });
                _orders.Add(new OrderInfo() { OrderID = 1007, CustomerName = "Frederique Citeaux", Country = "France", CustomerID = "BLONP", UnitPrice = 107.00, IsDelivered = false });
                _orders.Add(new OrderInfo() { OrderID = 1008, CustomerName = "Martin Sommer", Country = "Spain", CustomerID = "BOLID", UnitPrice = 350.00, IsDelivered = true });
                _orders.Add(new OrderInfo() { OrderID = 1009, CustomerName = "Laurence Lebihan", Country = "France", CustomerID = "BONAP", UnitPrice = 200.30, IsDelivered = true });
                _orders.Add(new OrderInfo() { OrderID = 1010, CustomerName = "Elizabeth Lincoln", Country = "Canada", CustomerID = "BOTTM", UnitPrice = 540.00, IsDelivered = false });
            }
           
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }

    public class TableSummaryRowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            var data = value != null ? value as SummaryRecordEntry : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                var unitPrice = SummaryCreator.GetSummaryDisplayText(data, "UnitPrice", dataGrid.View);
                var count = SummaryCreator.GetSummaryDisplayText(data, "OrderID", dataGrid.View);

                return "Total Price : " + unitPrice.ToString() + " for " + count.ToString() + " Products ";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    public class UnitpriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //var unitprice = (int)value;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}

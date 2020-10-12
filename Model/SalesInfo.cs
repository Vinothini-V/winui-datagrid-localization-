using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Localization
{
    public class SalesInfo : INotifyPropertyChanged
    {
        #region private members

        private int _SupplierID;
        private int _salesOrderID;
        private int _orderId;
        private string _country;

        #endregion

        #region public properties

        [Range(103, 109, ErrorMessage = "Supplier can hold value between 103 and 109")]

        public int SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                _SupplierID = value;
                RaisePropertyChanged("SupplierID");
            }
        }

        public int SalesOrderID
        {
            get
            {
                return _salesOrderID;
            }
            set
            {
                _salesOrderID = value;
                RaisePropertyChanged("SalesOrderID");
            }
        }

        public int OrderID
        {
            get
            {
                return _orderId;
            }
            set
            {
                _orderId = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                RaisePropertyChanged("City");
            }
        }

        #endregion

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
       
    }
}

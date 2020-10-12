using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Localization
{
    public class ProductInfo : INotifyPropertyChanged
    {
        #region private members

        private int _orderID;
        private int _ProductID;
        private double _discount;

        #endregion

        #region public properties

        [Range(11, 14, ErrorMessage = "OrderID can hold value between 11 and 14")]

        public int OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                _orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                RaisePropertyChanged("Discount");
            }
        }

        public int ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                _ProductID = value;
                RaisePropertyChanged("ProductID");
            }
        }
        private ObservableCollection<SupplierInfo> supplierdetails;

        public ObservableCollection<SupplierInfo> SupplierDetails
        {
            get
            {
                return supplierdetails;
            }
            set
            {
                supplierdetails = value;
                RaisePropertyChanged("SupplierDetails");
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

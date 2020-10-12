using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class BaseEmployee : NotificationObject
    {
        private int _EmployeeID;
       
        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }
    }

    public class SupplierInfo:NotificationObject
    {
        private int _SupplierID;
        private int supplierName;
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

        public int SupplierName
        {
            get
            {
                return supplierName;
            }
            set
            {
                supplierName = value;
                RaisePropertyChanged("SupplierName");
            }
        }
        }
}

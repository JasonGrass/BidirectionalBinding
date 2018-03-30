using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BidirectionalBindingDemo.ViewModel
{
    class WangViewModel : INotifyPropertyChanged
    {


        private string _host;

        public string Host
        {
            get => _host;
            set
            {
                if (_host != value)
                {
                    _host = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _wangAge;


        public string WangAge
        {
            get => _wangAge;
            set
            {
                if (_wangAge != value)
                {
                    _wangAge = value;
                    OnPropertyChanged();
                }
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

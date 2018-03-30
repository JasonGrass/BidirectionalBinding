using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BidirectionalBindingDemo.ViewModel
{
    class MiaoViewModel : INotifyPropertyChanged
    {


        private string _lord;

        public string Lord
        {
            get => _lord;
            set
            {
                if (_lord != value)
                {
                    _lord = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _miaoAge;


        public int MiaoAge
        {
            get => _miaoAge;
            set
            {
                if (_miaoAge != value)
                {
                    _miaoAge = value;
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

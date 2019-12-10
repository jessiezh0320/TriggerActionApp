using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MultiTriggerApp1
{
    public class MyViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool _valueA, _valueB;

        public MyViewModel()
        {
            ValueA = false;
            ValueB = false;
        }

        public bool ValueA
        {
            get
            {
                return _valueA;
            }
            set
            {
                if (_valueA != value)
                {
                    _valueA = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ValueA"));
                }
            }
        }

        public bool ValueB
        {
            get
            {
                return _valueB;
            }
            set
            {
                if (_valueB != value)
                {
                    _valueB = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ValueB"));
                }
            }
        }
    }
}

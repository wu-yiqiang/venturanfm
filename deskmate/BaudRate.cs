using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace deskmate
{
    class BaudRates : ObservableCollection<Int128>
    {
        public BaudRates()
        {
            Add(9600);
            Add(19200);
            Add(38400);
            Add(57600);
            Add(115200);
        }
    }
}

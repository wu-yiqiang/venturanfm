using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace deskmate
{
    class SerialPorts : ObservableCollection<string>
    {
        public SerialPorts()
        {
            Add("COM1");
            Add("COM2");
            Add("COM3");
            Add("COM4");
            Add("COM5");
        }
    }

}



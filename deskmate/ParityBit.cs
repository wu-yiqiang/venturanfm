using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace deskmate
{
    class ParityBits : ObservableCollection<string>
    {
        public ParityBits()
        {
            Add("None");
            Add("Odd");
            Add("Even");
            Add("Mark");
            Add("Space");
        }
    }
}

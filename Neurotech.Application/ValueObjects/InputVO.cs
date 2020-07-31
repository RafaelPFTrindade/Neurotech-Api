using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ValueObjects
{
    public class InputVO
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public object Order { get; set; }
        public object Visible { get; set; }
    }
}

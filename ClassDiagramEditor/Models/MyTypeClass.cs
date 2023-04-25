using Avalonia;
using DynamicData;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models
{
    public class MyTypeClass : AbstractDiagram
    {
        public MyTypeClass(string name)
        {
            Name = name;
        }
    }
}

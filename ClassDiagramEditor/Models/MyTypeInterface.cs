using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models
{
    public class MyTypeInterface : AbstractDiagram
    {
        public MyTypeInterface(string name) 
        {
            Name = name;
        }
    }
}

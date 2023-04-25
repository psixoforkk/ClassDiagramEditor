using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public class DependencyConnectorClass : AbstractConnector
    {
        public override void CalculateTip()
        {
            Point newTopPoint = new Point(-10, -10);
            Point newDownPoint = new Point(-10, 10);
            newTopPoint += EndPoint;
            newDownPoint += EndPoint;
            FirstTipPoint = newTopPoint;
            SecondTipPoint = newDownPoint;
        }
    }
}

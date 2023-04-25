using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public class ImplementationConnectorClass : AbstractConnector
    {
        public override void CalculateTip()
        {
            Point newTopPoint = new Point(-10, 0);
            Point newTopPoints = new Point(0, -10);
            Point newTopPointss = new Point(0, 20);
            newTopPoint += EndPoint;
            newTopPoints += newTopPoint;
            newTopPointss += newTopPoints;
            FirstTipPoint = newTopPoint;
            ListPoint = new List<Point>();
            ListPoint.Add(newTopPoint);
            ListPoint.Add(newTopPoints);
            ListPoint.Add(EndPoint);
            ListPoint.Add(newTopPointss);
            ListPoint.Add(FirstTipPoint);
        }
    }
}

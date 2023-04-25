using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public class CompositionConnectoClass : AbstractConnector
    {

        public override void CalculateTip()
        {
            Point newTopPoint = new Point(-30, 0);
            Point newTopPoints = new Point(15, -10);
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

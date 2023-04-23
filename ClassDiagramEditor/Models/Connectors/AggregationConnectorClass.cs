using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public class AggregationConnectorClass : AbstractNotifyPropertyChanged, IType, IDisposable
    {
        private Point startPoint;
        private Point endPoint;
        private Point firstTipPoint;
        private List<Point> listPoint;
        private MyTypeClass firstDiagram;
        private MyTypeClass secondDiagram;
        public string Name { get; set; }

        public MyTypeClass FirstDiagram
        {
            get => firstDiagram;
            set
            {
                if (firstDiagram != null)
                {
                    firstDiagram.ChangeStartPoint -= OnFirstDiagramPositionChanged;
                }
                firstDiagram = value;
                if (firstDiagram != null)
                {
                    firstDiagram.ChangeStartPoint += OnFirstDiagramPositionChanged;
                }
            }
        }
        public MyTypeClass SecondDiagram
        {
            get => secondDiagram;
            set
            {
                if (secondDiagram != null)
                {
                    secondDiagram.ChangeStartPoint -= OnSecondDiagramPositionChanged;
                }
                secondDiagram = value;
                if (secondDiagram != null)
                {
                    secondDiagram.ChangeStartPoint += OnSecondDiagramPositionChanged;
                }
            }
        }
        private void CalculateTip()
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
        private void OnFirstDiagramPositionChanged(object? sender, ChangeStartPointEventArgs e)
        {
            StartPoint += e.NewStartPoint - e.OldStartPoint;
        }
        private void OnSecondDiagramPositionChanged(object? sender, ChangeStartPointEventArgs e)
        {
            EndPoint += e.NewStartPoint - e.OldStartPoint;
        }
        public List<Point> ListPoint
        {
            get => listPoint;
            set => SetAndRaise(ref listPoint, value);
        }
        public Point StartPoint
        {
            get => startPoint;
            set => SetAndRaise(ref startPoint, value);
        }

        public Point EndPoint
        {
            get => endPoint;
            set
            {
                SetAndRaise(ref endPoint, value);
                CalculateTip();
            }
        }
        public Point FirstTipPoint
        {
            get => firstTipPoint;
            set => SetAndRaise(ref firstTipPoint, value);
        }
        public void Dispose()
        {
            if (FirstDiagram != null)
            {
                FirstDiagram.ChangeStartPoint -= OnFirstDiagramPositionChanged;
            }
            if (SecondDiagram != null)
            {
                SecondDiagram.ChangeStartPoint -= OnSecondDiagramPositionChanged;
            }
        }
    }
}

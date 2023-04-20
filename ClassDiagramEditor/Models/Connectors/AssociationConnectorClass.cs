using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public class AssociationConnectorClass : AbstractNotifyPropertyChanged, IType, IDisposable
    {
        private Point startPoint;
        private Point endPoint;
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

        private void OnFirstDiagramPositionChanged(object? sender, ChangeStartPointEventArgs e)
        {
            StartPoint += e.NewStartPoint - e.OldStartPoint;
        }
        private void OnSecondDiagramPositionChanged(object? sender, ChangeStartPointEventArgs e)
        {
            EndPoint += e.NewStartPoint - e.OldStartPoint;
        }
        public Point StartPoint
        {
            get => startPoint;
            set => SetAndRaise(ref startPoint, value);
        }

        public Point EndPoint
        {
            get => endPoint;
            set => SetAndRaise(ref endPoint, value);
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

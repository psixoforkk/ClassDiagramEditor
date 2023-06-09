﻿using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramEditor.Models.Connectors
{
    public abstract class AbstractConnector : AbstractNotifyPropertyChanged, IType, IDisposable
    {
        private Point startPoint;
        private Point endPoint;
        private Point firstTipPoint;
        private Point secondTipPoint;
        private List<Point> listPoint;
        private AbstractDiagram firstDiagram;
        private AbstractDiagram secondDiagram;
        public string Name { get; set; }

        public AbstractDiagram FirstDiagram
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
        public AbstractDiagram SecondDiagram
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
        public abstract void CalculateTip();
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
        public Point SecondTipPoint
        {
            get => secondTipPoint;
            set => SetAndRaise(ref secondTipPoint, value);
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

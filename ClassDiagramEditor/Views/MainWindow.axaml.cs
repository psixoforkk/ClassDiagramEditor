using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.VisualTree;
using ClassDiagramEditor.Models;
using ClassDiagramEditor.Models.Connectors;
using ClassDiagramEditor.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using System.Linq;

namespace ClassDiagramEditor.Views
{
    public partial class MainWindow : Window
    {
        private Point pointPointerPressed;
        private Point pointerPositionIntoShape;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnPointerPressed(object? sender, PointerPressedEventArgs pointerPressedEventArgs)
        {
            if (pointerPressedEventArgs.Source is Control control)
            {
                if (control.DataContext is MyTypeClass myClassDiagram)
                {
                    if (this.DataContext is MainWindowViewModel mainWindowViewModel)
                    {
                        if (mainWindowViewModel.AddDiagramCheck == true)
                        {
                            pointPointerPressed = pointerPressedEventArgs
                            .GetPosition(
                            this.GetVisualDescendants()
                            .OfType<Canvas>()
                            .FirstOrDefault(canvas => string.IsNullOrEmpty(canvas.Name) == false &&
                             canvas.Name.Equals("canvas")));
                            if (pointerPressedEventArgs.Source is not Rectangle)
                            {
                                pointerPositionIntoShape = pointerPressedEventArgs.GetPosition(control);
                                this.PointerMoved += PointerMoveDragShape;
                                this.PointerReleased += PointerPressedReleasedDragShape;
                            }
                            else
                            {
                                if (mainWindowViewModel.AssociationConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new AssociationConnectorClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                                if (mainWindowViewModel.InheritanceConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new InheritanceConnectorClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                                if (mainWindowViewModel.ImplementationConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new ImplementationConnectorClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                                if (mainWindowViewModel.DependencyConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new DependencyConnectorClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                                if (mainWindowViewModel.AggregationConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new AggregationConnectorClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                                if (mainWindowViewModel.CompositionConnectorCheck == true)
                                {
                                    mainWindowViewModel.Diagrams.Add(new CompositionConnectoClass
                                    {
                                        StartPoint = pointPointerPressed,
                                        EndPoint = pointPointerPressed,
                                        Name = "Connector",
                                        FirstDiagram = myClassDiagram
                                    });
                                    this.PointerMoved += PointerMoveDrawConnectionControl;
                                    this.PointerReleased += PointerPressedReleasedDrawConnectionControl;
                                }
                            }
                        }
                        if (mainWindowViewModel.ScaleDiagramCheck == true)
                        {

                        }
                        if (mainWindowViewModel.DeleteDiagramCheck == true)
                        {
                            foreach (IType connector in mainWindowViewModel.Diagrams.ToList())
                            {
                                if (connector.Name == "Connector")
                                {
                                    AssociationConnectorClass newConnector = connector as AssociationConnectorClass;
                                    if (newConnector.FirstDiagram == myClassDiagram || newConnector.SecondDiagram == myClassDiagram)
                                    {
                                        mainWindowViewModel.Diagrams.Remove(connector);
                                    }
                                }
                            }
                            mainWindowViewModel.Diagrams.Remove(myClassDiagram);
                        }
                    }
                }
                else if (control.DataContext is MyTypeInterface myInterfaceDiagram)
                {
                    if (this.DataContext is MainWindowViewModel mainWindowViewModel)
                    {
                        if (mainWindowViewModel.AddDiagramCheck == true)
                        {
                            pointPointerPressed = pointerPressedEventArgs
                            .GetPosition(
                            this.GetVisualDescendants()
                            .OfType<Canvas>()
                            .FirstOrDefault(canvas => string.IsNullOrEmpty(canvas.Name) == false &&
                             canvas.Name.Equals("canvas")));
                            if (pointerPressedEventArgs.Source is not Rectangle)
                            {
                                pointerPositionIntoShape = pointerPressedEventArgs.GetPosition(control);
                                this.PointerMoved += PointerMoveDragShape;
                                this.PointerReleased += PointerPressedReleasedDragShape;
                            }
                            else
                            {
                                
                            }
                        }
                        if (mainWindowViewModel.ScaleDiagramCheck == true)
                        {

                        }
                        if (mainWindowViewModel.DeleteDiagramCheck == true)
                        {
                            mainWindowViewModel.Diagrams.Remove(myInterfaceDiagram);
                        }
                    }
                }
                else if (this.DataContext is MainWindowViewModel mainWindowViewModel)
                {
                    if (mainWindowViewModel.InterfaceDiagramCheck == true && mainWindowViewModel.AddDiagramCheck == true)
                    {
                        pointPointerPressed = pointerPressedEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault(canvas => string.IsNullOrEmpty(canvas.Name) == false &&
                        canvas.Name.Equals("canvas")));
                        mainWindowViewModel.Diagrams.Add(new MyTypeInterface
                        {
                            StartPoint = pointPointerPressed
                        });
                    }
                    if (mainWindowViewModel.ClassDiagramCheck == true && mainWindowViewModel.AddDiagramCheck == true)
                    {
                        pointPointerPressed = pointerPressedEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault(canvas => string.IsNullOrEmpty(canvas.Name) == false &&
                        canvas.Name.Equals("canvas")));
                        mainWindowViewModel.Diagrams.Add(new MyTypeClass
                        {
                            StartPoint = pointPointerPressed
                        });
                    }
                }
            }
        }
        private void PointerMoveDrawConnectionControl(object? sender, PointerEventArgs pointerEventArgs)
        {
            if (this.DataContext is MainWindowViewModel mainWindowViewModel)
            {
                Debug.WriteLine(sender);
                if (mainWindowViewModel.AssociationConnectorCheck == true)
                {
                    AssociationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as AssociationConnectorClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
                if (mainWindowViewModel.InheritanceConnectorCheck == true)
                {
                    InheritanceConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as InheritanceConnectorClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
                if (mainWindowViewModel.ImplementationConnectorCheck == true)
                {
                    ImplementationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as ImplementationConnectorClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
                if (mainWindowViewModel.DependencyConnectorCheck == true)
                {
                    DependencyConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as DependencyConnectorClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
                if (mainWindowViewModel.AggregationConnectorCheck == true)
                {
                    AggregationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as AggregationConnectorClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
                if (mainWindowViewModel.CompositionConnectorCheck == true)
                {
                    CompositionConnectoClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as CompositionConnectoClass;
                    Point currentPointerPosition = pointerEventArgs
                        .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>()
                        .FirstOrDefault());
                    connector.EndPoint = new Point(currentPointerPosition.X - 1, currentPointerPosition.Y - 1);
                }
            }
        }
        private void PointerPressedReleasedDrawConnectionControl(object? sender, PointerReleasedEventArgs pointerReleasedEventArgs)
        {
            this.PointerMoved -= PointerMoveDrawConnectionControl;
            this.PointerReleased -= PointerPressedReleasedDrawConnectionControl;
            var canvas = this.GetVisualDescendants()
                .OfType<Canvas>()
                .FirstOrDefault(canvas => string.IsNullOrEmpty(canvas.Name) == false && canvas.Name.Equals("canvas"));
            var coords = pointerReleasedEventArgs.GetPosition(canvas);
            var element = canvas.InputHitTest(coords);
            MainWindowViewModel mainWindowViewModel = this.DataContext as MainWindowViewModel;
            if (element is Rectangle rectangle)
            {
                if (rectangle.DataContext is MyTypeClass secondTypeClass)
                {
                    if (mainWindowViewModel.AssociationConnectorCheck == true)
                    {
                        AssociationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as AssociationConnectorClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                    if (mainWindowViewModel.InheritanceConnectorCheck == true)
                    {
                        InheritanceConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as InheritanceConnectorClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                    if (mainWindowViewModel.ImplementationConnectorCheck == true)
                    {
                        ImplementationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as ImplementationConnectorClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                    if (mainWindowViewModel.DependencyConnectorCheck == true)
                    {
                        DependencyConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as DependencyConnectorClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                    if (mainWindowViewModel.AggregationConnectorCheck == true)
                    {
                        AggregationConnectorClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as AggregationConnectorClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                    if (mainWindowViewModel.CompositionConnectorCheck == true)
                    {
                        CompositionConnectoClass connector = mainWindowViewModel.Diagrams[mainWindowViewModel.Diagrams.Count - 1] as CompositionConnectoClass;
                        if (connector.FirstDiagram == secondTypeClass)
                        {
                            mainWindowViewModel.Diagrams.Remove(connector);
                            return;
                        }
                        connector.SecondDiagram = secondTypeClass;
                        return;
                    }
                }
            }
            mainWindowViewModel.Diagrams.RemoveAt(mainWindowViewModel.Diagrams.Count - 1);
        }
        private void PointerMoveDragShape(object? sender, PointerEventArgs pointerEventArgs)
        {
            if (pointerEventArgs.Source is Control control)
            {
                if (control.DataContext is MyTypeClass myClassDiagram)
                {
                    Point currentPointerPosition = pointerEventArgs
                    .GetPosition(
                    this.GetVisualDescendants()
                    .OfType<Canvas>()
                    .FirstOrDefault());
                    myClassDiagram.StartPoint = new Point(
                        currentPointerPosition.X - pointerPositionIntoShape.X,
                        currentPointerPosition.Y - pointerPositionIntoShape.Y);
                }
                if (control.DataContext is MyTypeInterface myTypeInterface)
                {
                    Point currentPointerPosition = pointerEventArgs
                    .GetPosition(
                    this.GetVisualDescendants()
                    .OfType<Canvas>()
                    .FirstOrDefault());
                    myTypeInterface.StartPoint = new Point(
                        currentPointerPosition.X - pointerPositionIntoShape.X,
                        currentPointerPosition.Y - pointerPositionIntoShape.Y);
                }
            }
        }

        private void PointerPressedReleasedDragShape(object? sender,
            PointerReleasedEventArgs pointerReleasedEventArgs)
        {
            this.PointerMoved -= PointerMoveDragShape;
            this.PointerReleased -= PointerPressedReleasedDragShape;
        }
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using System.Collections.Generic;

namespace ClassDiagramEditor.Views.Controls
{
    public class ImplementationConnectorControl : TemplatedControl
    {
        public static readonly StyledProperty<Point> CustomPointsStartProperty =
            AvaloniaProperty.Register<ImplementationConnectorControl, Point>("CustomPointsStart");
        public Point CustomPointsStart
        {
            get => GetValue(CustomPointsStartProperty);
            set => SetValue(CustomPointsStartProperty, value);
        }
        public static readonly StyledProperty<Point> CustomPointsEndProperty =
            AvaloniaProperty.Register<ImplementationConnectorControl, Point>("CustomPointsEnd");
        public Point CustomPointsEnd
        {
            get => GetValue(CustomPointsEndProperty);
            set => SetValue(CustomPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomFirstTipPointsEndProperty =
            AvaloniaProperty.Register<ImplementationConnectorControl, Point>("CustomFirstTipPointsEnd");
        public Point CustomFirstTipPointsEnd
        {
            get => GetValue(CustomFirstTipPointsEndProperty);
            set => SetValue(CustomFirstTipPointsEndProperty, value);
        }
        public static readonly StyledProperty<List<Point>> CustomListTipPointsProperty =
            AvaloniaProperty.Register<ImplementationConnectorControl, List<Point>>("CustomListTipPoints");
        public List<Point> CustomListTipPoints
        {
            get => GetValue(CustomListTipPointsProperty);
            set => SetValue(CustomListTipPointsProperty, value);
        }
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using System.Collections.Generic;

namespace ClassDiagramEditor.Views.Controls
{
    public class CompositionConnectorControl : TemplatedControl
    {
        public static readonly StyledProperty<Point> CustomPointsStartProperty =
            AvaloniaProperty.Register<AggregationConnectorControl, Point>("CustomPointsStart");
        public Point CustomPointsStart
        {
            get => GetValue(CustomPointsStartProperty);
            set => SetValue(CustomPointsStartProperty, value);
        }
        public static readonly StyledProperty<Point> CustomPointsEndProperty =
            AvaloniaProperty.Register<AggregationConnectorControl, Point>("CustomPointsEnd");
        public Point CustomPointsEnd
        {
            get => GetValue(CustomPointsEndProperty);
            set => SetValue(CustomPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomFirstTipPointsEndProperty =
            AvaloniaProperty.Register<AggregationConnectorControl, Point>("CustomFirstTipPointsEnd");
        public Point CustomFirstTipPointsEnd
        {
            get => GetValue(CustomFirstTipPointsEndProperty);
            set => SetValue(CustomFirstTipPointsEndProperty, value);
        }
        public static readonly StyledProperty<List<Point>> CustomListTipPointsProperty =
            AvaloniaProperty.Register<AggregationConnectorControl, List<Point>>("CustomListTipPoints");
        public List<Point> CustomListTipPoints
        {
            get => GetValue(CustomListTipPointsProperty);
            set => SetValue(CustomListTipPointsProperty, value);
        }
    }
}

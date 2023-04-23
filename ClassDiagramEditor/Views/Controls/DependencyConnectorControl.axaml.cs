using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace ClassDiagramEditor.Views.Controls
{
    public class DependencyConnectorControl : TemplatedControl
    {
        public static readonly StyledProperty<Point> CustomPointsStartProperty =
            AvaloniaProperty.Register<DependencyConnectorControl, Point>("CustomPointsStart");
        public Point CustomPointsStart
        {
            get => GetValue(CustomPointsStartProperty);
            set => SetValue(CustomPointsStartProperty, value);
        }
        public static readonly StyledProperty<Point> CustomPointsEndProperty =
            AvaloniaProperty.Register<DependencyConnectorControl, Point>("CustomPointsEnd");
        public Point CustomPointsEnd
        {
            get => GetValue(CustomPointsEndProperty);
            set => SetValue(CustomPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomFirstTipPointsEndProperty =
            AvaloniaProperty.Register<DependencyConnectorControl, Point>("CustomFirstTipPointsEnd");
        public Point CustomFirstTipPointsEnd
        {
            get => GetValue(CustomFirstTipPointsEndProperty);
            set => SetValue(CustomFirstTipPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomSecondTipPointsEndProperty =
            AvaloniaProperty.Register<DependencyConnectorControl, Point>("CustomSecondTipPointsEnd");
        public Point CustomSecondTipPointsEnd
        {
            get => GetValue(CustomSecondTipPointsEndProperty);
            set => SetValue(CustomSecondTipPointsEndProperty, value);
        }
    }
}

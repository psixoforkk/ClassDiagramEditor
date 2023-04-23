using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace ClassDiagramEditor.Views.Controls
{
    public class AssociationConnectorControl : TemplatedControl
    {
        public static readonly StyledProperty<Point> CustomPointsStartProperty =
            AvaloniaProperty.Register<AssociationConnectorControl, Point>("CustomPointsStart");
        public Point CustomPointsStart
        {
            get => GetValue(CustomPointsStartProperty);
            set => SetValue(CustomPointsStartProperty, value);
        }
        public static readonly StyledProperty<Point> CustomPointsEndProperty =
            AvaloniaProperty.Register<AssociationConnectorControl, Point>("CustomPointsEnd");
        public Point CustomPointsEnd
        {
            get => GetValue(CustomPointsEndProperty);
            set => SetValue(CustomPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomFirstTipPointsEndProperty =
            AvaloniaProperty.Register<AssociationConnectorControl, Point>("CustomFirstTipPointsEnd");
        public Point CustomFirstTipPointsEnd
        {
            get => GetValue(CustomFirstTipPointsEndProperty);
            set => SetValue(CustomFirstTipPointsEndProperty, value);
        }
        public static readonly StyledProperty<Point> CustomSecondTipPointsEndProperty =
            AvaloniaProperty.Register<AssociationConnectorControl, Point>("CustomSecondTipPointsEnd");
        public Point CustomSecondTipPointsEnd
        {
            get => GetValue(CustomSecondTipPointsEndProperty);
            set => SetValue(CustomSecondTipPointsEndProperty, value);
        }

    }
}

namespace Figures; 

/// <summary>
/// Represents a circle.
/// </summary>
public class Circle : IFigure {
    private double _radius;

    /// <summary>
    /// Radius of the circle.
    /// </summary>
    /// <exception cref="ArgumentException">Throws if there is an attempt to set a value less or equal 0.</exception>
    public double Radius {
        get => _radius;
        set {
            if (value <= 0) {
                throw new ArgumentException(Messages.FieldShouldBePositiveValueMessage(nameof(Radius)));
            }

            _radius = value;
        }
    }

    /// <summary>
    /// Returns a square of the circle.
    /// </summary>
    public double Square => Math.PI * Math.Pow(_radius, 2);

    /// <summary>
    /// Default constructor that sets a radius to 1.
    /// </summary>
    public Circle() {
        _radius = 1;
    }

    /// <summary>
    /// Constructor that sets a radius to a given value. Value cannot be less or equal 0.
    /// </summary>
    /// <param name="radius">Radius of the circle.</param>
    public Circle(double radius) {
        Radius = radius;
    }
}
namespace Figures;

/// <summary>
/// Represents a triangle.
/// </summary>
public class Triangle : IFigure {
    private double _a;
    private double _b;
    private double _c;

    /// <summary>
    /// First side of the triangle.
    /// </summary>
    /// <exception cref="ArgumentException">Throws if there is an attempt to set a value less or equal 0.</exception>
    public double A {
        get => _a;
        set {
            if (value <= 0) {
                throw new ArgumentException(Messages.FieldShouldBePositiveValueMessage(nameof(A)));
            }

            _a = value;
        }
    }

    /// <summary>
    /// Second side of the triangle.
    /// </summary>
    /// <exception cref="ArgumentException">Throws if there is an attempt to set a value less or equal 0.</exception>
    public double B {
        get => _b;
        set {
            if (value <= 0) {
                throw new ArgumentException(Messages.FieldShouldBePositiveValueMessage(nameof(B)));
            }

            _b = value;
        }
    }

    /// <summary>
    /// Third side of the triangle.
    /// </summary>
    /// <exception cref="ArgumentException">Throws if there is an attempt to set a value less or equal 0.</exception>
    public double C {
        get => _c;
        set {
            if (value <= 0) {
                throw new ArgumentException(Messages.FieldShouldBePositiveValueMessage(nameof(C)));
            }

            _c = value;
        }
    }

    /// <summary>
    /// Returns a square of triangle using Heron's formula.
    /// </summary>
    public double Square {
        get {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }

    /// <summary>
    /// Default constructor that sets the sides to 1.
    /// </summary>
    public Triangle() {
        _a = 1;
        _b = 1;
        _c = 1;
    }

    /// <summary>
    /// Constructor that sets the sides to a given values. Values cannot be less or equal 0.
    /// </summary>
    /// <param name="a">First side.</param>
    /// <param name="b">Second side.</param>
    /// <param name="c">Third side.</param>
    public Triangle(double a, double b, double c) {
        A = a;
        B = b;
        C = c;

        CheckExists();
    }

    /// <summary>
    /// Checks that the triangle can exist.
    /// </summary>
    /// <exception cref="ArgumentException">Throws if the triangle cannot exist.</exception>
    private void CheckExists() {
        if (_a + _b <= _c ||
            _b + _c <= _a ||
            _c + _a <= _b) {
            throw new ArgumentException(Messages.TriangleRuleErrorMessage);
        }
    }

    public bool IsRectangular() {
        var hypotenuse = Math.Max(_a, Math.Max(_b, _c));
        const double tolerance = 10E-9;

        if (Math.Abs(hypotenuse - _a) < tolerance) {
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(_b, 2) + Math.Pow(_c, 2))) < tolerance;
        }

        if (Math.Abs(hypotenuse - _b) < tolerance) {
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(_a, 2) + Math.Pow(_c, 2))) < tolerance;
        }

        return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(_a, 2) + Math.Pow(_b, 2))) < tolerance;
    }
}
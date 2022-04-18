using System;
using Figures;
using Xunit;

namespace FigureTests; 

public class TriangleTests {
    [Theory]
    [InlineData(-1, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, -1)]
    public void NegativeValueExceptionTest(double a, double b, double c) {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(1, 0, 1)]
    [InlineData(1, 1, 0)]
    public void ZeroValueExceptionTest(double a, double b, double c) {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(10, 1, 1)]
    [InlineData(1, 10, 1)]
    [InlineData(1, 1, 10)]
    public void InvalidTriangleException(double a, double b, double c) {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void PositiveInfinityTest() {
        var t = new Triangle(double.MaxValue, double.MaxValue, double.MaxValue);
        Assert.Equal(double.PositiveInfinity, t.Square);
    }

    [Fact]
    public void SquareIntTest() {
        var c = new Triangle(10, 10, 10);
        Assert.Equal(43.3, Math.Round(c.Square, 1));
    }

    [Fact]
    public void SquareDoubleTest() {
        var t = new Triangle(5.5, 6.5, 10.3);
        Assert.Equal(15.78, Math.Round(t.Square, 2));
    }
    
    [Fact]
    public void DefaultConstructorTest() {
        var t = new Triangle();
        Assert.Equal(1, t.A);
        Assert.Equal(1, t.B);
        Assert.Equal(1, t.C);
        Assert.Equal(0.43, Math.Round(t.Square, 2));
    }

    [Theory]
    [InlineData(5, 12, 13)]
    [InlineData(7, 25, 24)]
    [InlineData(5, 4, 3)]
    public void TrueIsRectangularTest(double a, double b, double c) {
        var t = new Triangle(a, b, c);
        Assert.True(t.IsRectangular());
    }

    [Theory]
    [InlineData(3, 3, 3)]
    [InlineData(4, 9, 10)]
    [InlineData(10, 15, 20)]
    public void FalseIsRectangularTest(double a, double b, double c) {
        var t = new Triangle(a, b, c);
        Assert.False(t.IsRectangular());
    }
}
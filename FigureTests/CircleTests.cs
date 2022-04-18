using System;
using Figures;
using Xunit;

namespace FigureTests; 

public class CircleTests {
    [Fact]
    public void NegativeValueExceptionTest() {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Fact]
    public void ZeroValueExceptionTest() {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void PositiveInfinityTest() {
        var c = new Circle(double.MaxValue);
        Assert.Equal(double.PositiveInfinity, c.Square);
    }

    [Fact]
    public void SquareIntTest() {
        var c = new Circle(10);
        Assert.Equal(314.16, Math.Round(c.Square, 2));
    }

    [Fact]
    public void SquareDoubleTest() {
        var c = new Circle(5.3);
        Assert.Equal(88.25, Math.Round(c.Square, 2));
    }

    [Fact]
    public void DefaultConstructorTest() {
        var c = new Circle();
        Assert.Equal(1, c.Radius);
        Assert.Equal(3.14, Math.Round(c.Square, 2));
    }
}
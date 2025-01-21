using ExerciceQuadraticSolver;

namespace ExerciceQuadraticSolverTests;

public class QuadraticSolverTests
{
    private QuadraticSolver _solver;

    public QuadraticSolverTests()
    {
        _solver = new QuadraticSolver();
    }

    [Fact]
    public void Solve_ShouldThrowArgumentException_WhenAIsZero()
    {
        // Arrange
        double a = 0;
        double b = 4;
        double c = 3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _solver.Solve(a, b, c));
    }

    [Fact]
    public void Solve_ShouldReturnTwoValues_WhenDiscriminantIsPositive()
    {
        // Arrange
        double a = 2;
        double b = -1;
        double c = -6;

        // Act
        (double?, double?) result = _solver.Solve(a, b, c);
        var expected = (x1: 2.0, x2: -3 / 2.0);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Solve_ShouldReturnOneValue_WhenDiscriminantEqualZero()
    {
        // Arrange
        double a = 2;
        double b = -3;
        double c = 9 / 8.0;

        (double?, double?) expected = (3 / 4.0, null);

        // Act
        (double?, double?) result = _solver.Solve(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 3, 10)]
    [InlineData(1, 2, 3)]
    [InlineData(4, 1, 4)]
    [InlineData(1, 1, 1)]
    public void Solve_ShoundReturnNoValue_WhenDiscriminantIsNegative(double a, double b, double c)
    {
        // Arrange
        (double?, double?) expected = (null, null);

        // Act
        (double?, double?) result = _solver.Solve(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }
}
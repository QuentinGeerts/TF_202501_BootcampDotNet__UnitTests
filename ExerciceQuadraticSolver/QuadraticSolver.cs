namespace ExerciceQuadraticSolver;

public class QuadraticSolver
{
    public (double? x1, double? x2) Solve(double a, double b, double c)
    {
        if (a == 0) throw new ArgumentException("Le coefficient a ne peut pas être nulle");

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            // 2 solutions
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (x1, x2);
        }
        else if (discriminant == 0)
        {
            // 1 solution
            double x1 = -b / (2 * a);
            return (x1, null);
        }
        else
        {
            // 0 solution
            return (null, null);
        }
    }
}

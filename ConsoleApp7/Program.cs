public class shapes
{

	Func<double, double> A = CirclePerimeter;
	Func<double, double> B = CircleArea;

	static public List<Func<Double, Double>> Circle = new List<Func<Double, Double>>
	{ CirclePerimeter,CircleArea};

	Func<double, double, double> C = RectanglePerimeter;
	Func<double, double, double> D = RectangleArea;

	static List<Func<Double, Double, Double>> Rectangle = new List<Func<Double, Double, Double>>
	{ RectanglePerimeter, RectangleArea };


	Func<double, double, double> E = TrianglePerimeter;
	Func<double, double, double> F = TriangleArea;
	static List<Func<Double, Double, Double>> Triangle = new List<Func<Double, Double, Double>>
	{ TrianglePerimeter, RectangleArea };



	public static void Main(string[] args)
	{


		Console.WriteLine(Circle[0](3.5).ToString());
		Console.WriteLine(Circle[1](3.5).ToString());

		Console.WriteLine(Rectangle[0](3.5, 4).ToString());
		Console.WriteLine(Rectangle[1](3.5, 4).ToString());


		Console.WriteLine(Triangle[0](3.5, 4).ToString());
		Console.WriteLine(Triangle[1](3.5, 4).ToString());



		Console.WriteLine("CircleArea " + CircleArea(3.5).ToString());
		Console.WriteLine(RectanglePerimeter(3.5, 4).ToString());





	}
	static double CirclePerimeter(double radius){ return Math.PI * 2 * radius; }
	static double CircleArea(double radius) { return radius * radius * Math.PI; }

	static double RectanglePerimeter(double height, double width) { return 2 * (height + width); }

	static double RectangleArea(double height, double width) { return height * width; }

	static double TrianglePerimeter(double height, double base_length) { return height * 3; }

	static double TriangleArea(double height, double base_length) { return 0.5 * height * base_length; }
}



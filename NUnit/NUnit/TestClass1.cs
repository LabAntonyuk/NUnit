using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace NUnit.Lab5NUnit
{
    [TestFixture]
    public class TestClass1
    {

        static object[] CircleFigure =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };


        static object[] TriangleFigure =
        {
                new object[] { 0, 0, 0 },
                new object[] { 1, 1, 1 },
                new object[] { 2, 2, 2 },
                new object[] { 3, 3, 3 },
                new object[] { 4, 4, 4 },
                new object[] { 5, 5, 5 },
                new object[] { 6, 6, 6 },
                new object[] { 7, 7, 7 },
                new object[] { 8, 8, 8 },
                new object[] { 9, 9, 9 },
                new object[] { 10, 10, 10 },
                new object[] { 11, 11, 11},
                new object[] { 12, 12, 12 },
                new object[] { 13, 13, 13 },
                new object[] { 14, 14, 14 },
                new object[] { 15, 15, 15 },
                new object[] { 16, 16, 16 },
                new object[] { 17, 17, 17 },
                new object[] { 18, 18, 18 },
                new object[] { 19, 19, 19 },
                new object[] { 20, 20, 20 }

        };
        
        static object[] SquareFigure =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };


        [Test, TestCaseSource("CircleFigure")]

        public void CircleArea(int n)
        {
            
            Circle circle = new Circle(n);
            double area = 3.141593 * n * n;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(circle.getAreaCircle(), 2));

        }

        [Test, TestCaseSource("CircleFigure")]
        public void CircleLenght(int n)
        {

            Circle circle = new Circle(n);
            double lenght = 2 * 3.141593 * n;
            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(circle.getLengthCircle(), 2));

        }

        [Test, TestCaseSource("SquareFigure")]
        public void SquareArea(int n)
        {

            Square square = new Square(n);
            double area = n * n;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(square.getAreaSquare(), 2));

        }

        [Test, TestCaseSource("SquareFigure")]
        public void SquareLenght(int n)
        {

            Square square = new Square(n);
            double lenght = 4 * n;
            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(square.getLengthSquare(), 2));

        }

        [Test, TestCaseSource("TriangleFigure")]
        public void TriangleLenght(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double lenght = n + p + q;
            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(triangle.getLengthTriangle(), 2));

        }

        [Test, TestCaseSource("TriangleFigure")]
        public void TriangleArea(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double perimeter = 1 / 2 * (n + p + q);
            double area = Math.Sqrt(perimeter * (perimeter - n) * (perimeter - p) * (perimeter - q));
            Assert.AreEqual(Math.Round(area, 2), Math.Round(triangle.getAreaTriangle(), 2));
        }

        

        [Test]
        public void TestCircleString()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("String"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestCircleFloat()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("1.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestCircleNegative()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(-10);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }

        [Test]
        public void TestSquareString()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(Convert.ToInt32("String"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareFloat()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(Convert.ToInt32("1.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareNegative()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(-10);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        [Test]
        public void TestTriangleString()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("String"), Convert.ToInt32("String"), Convert.ToInt32("String"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleFloat()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("1.5"), Convert.ToInt32("1.5"), Convert.ToInt32("1.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleNumberMines()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(-10, -10, -10);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}

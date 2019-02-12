
using ConsoleApp1;
using System;

using NUnit.Framework;



namespace ConsoleApp1.Tests
{
   
        [TestFixture]
        public class TriangleSolverTests
        {
        [Test]
        public void Sides1and7and5forNotPossible()
        {
            //Arrange
            int s1 = 1, s2 = 7, s3 = 5;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides8and8and8forEquilateral()
        {
            //Arrange
            int s1 = 8, s2 = 8, s3 = 8;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Equilateral Triangle");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void Sides5and6and7forScalene()
        {
            //Arrange
            int s1 = 5, s2 = 6, s3 = 7;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is a Scalene Triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Allzero()
        {
            //Arrange
            int s1 = 0, s2 = 0, s3 = 0;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides5and5and3forIsosceles()
        {
            //Arrange
            int s1 = 5, s2 = 5, s3 = 3;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Isosceles Triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides0and7and6forNotPossible()
        {
            //Arrange
            int s1 = 0, s2 = 7, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void SidesNegativeand4and7forNotPossible()
        {
            //Arrange
            int s1 = -7, s2 = 4, s3 = 7;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TwoSidesNegativeand5and6forNotPossible()
        {
            //Arrange
            int s1 = -5, s2 = -5, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }



    }
}

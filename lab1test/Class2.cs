using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab1test;

namespace Lab1test.Tests
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void Test_input_WithPositiveInteger_ReturnsArrayWithGivenSize()
        {
            int[] expected = new int[5];
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("5\n1\n2\n3\n4\n5\n"));

            result = Program.input();

            Assert.AreEqual(expected.Length, result.Length);
        }

        [Test]
        public void Test_kolVishSr_WithArray_ReturnsCountOfElementsGreaterThanAverage()
        {
            int[] tovar = { 1, 2, 3, 4, 5 };
            int expected = 2;

            int result = Program.kolVishSr(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_sort_WithArrayAndExistingValue_ReturnsArrayWithRemovedValue()
        {
            int[] tovar = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 4, 5 };
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("3\n"));

            result = Program.sort(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_output_WithArray_WritesArrayElementsToConsole()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            string expectedOutput = "Новый массив оставшихся товаров:\n1\n2\n3\n4\n5\n";

            // Capture console output
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            Program.output(a);

            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }

        [Test]
        public void Test_input_WithZeroItems_ReturnsEmptyArray()
        {
            int[] expected = new int[0];
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("0\n"));

            result = Program.input();

            Assert.AreEqual(expected.Length, result.Length);
        }

        [Test]
        public void Test_kolVishSr_WithEmptyArray_ReturnsZero()
        {
            int[] tovar = new int[0];
            int expected = 0;

            int result = Program.kolVishSr(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_sort_WithArrayAndNonExistingValue_ReturnsSameArray()
        {
            int[] tovar = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("10\n"));

            result = Program.sort(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_output_WithEmptyArray_WritesNoOutputToConsole()
        {
            int[] a = new int[0];
            string expectedOutput = "";

            // Capture console output
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            Program.output(a);

            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }

        [Test]
        public void Test_input_WithNegativeInteger_ReturnsArrayWithGivenSize()
        {
            int[] expected = new int[3];
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("3\n1\n2\n3\n"));

            result = Program.input();

            Assert.AreEqual(expected.Length, result.Length);
        }

        [Test]
        public void Test_kolVishSr_WithArrayWithEqualElements_ReturnsZero()
        {
            int[] tovar = { 1, 1, 1, 1, 1 };
            int expected = 0;

            int result = Program.kolVishSr(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_sort_WithEmptyArray_ReturnsEmptyArray()
        {
            int[] tovar = new int[0];
            int[] expected = new int[0];
            int[] result;

            // Mock user input
            Console.SetIn(new System.IO.StringReader("10\n"));

            result = Program.sort(tovar);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_output_WithArrayWithNegativeValues_WritesArrayElementsToConsole()
        {
            int[] a = { -1, -2, -3, -4, -5 };
            string expectedOutput = "Новый массив оставшихся товаров:\n-1\n-2\n-3\n-4\n-5\n";

            // Capture console output
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            Program.output(a);

            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }
    }
}
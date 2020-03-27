using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rozdz_1_Generics;

namespace Rozdz1_Generics_Test
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void New_Stack_IsEmpty()
        {
            // Arrange
            var stack = new MyStack();

            // Act

            // Assert
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void Four_Element_Stack_Is_Full_After_Add_Four_Element()
        {
            // Arrange
            var stack = new MyStack(capacity: 4);

            // Act
            stack.WriteElement(5);
            stack.WriteElement(10);
            stack.WriteElement(20);
            stack.WriteElement(50);

            // Assert
            Assert.IsTrue(stack.IsFull);
        }

        [TestMethod]
        public void Last_In_First_Out()
        {
            // Arrange
            var stack = new MyStack(capacity: 4);
            var value1 = 3.3;
            var value2 = 6.5;
            var value3 = 9.4;
            var value4 = 6.6;

            // Act
            stack.WriteElement(value1);
            stack.WriteElement(value2);
            stack.WriteElement(value3);
            stack.WriteElement(value4);

            // Assert
            Assert.AreEqual(value4, stack.ReadElement());
            Assert.AreEqual(value3, stack.ReadElement());
            Assert.AreEqual(value2, stack.ReadElement());
            Assert.AreEqual(value1, stack.ReadElement());
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void The_Output_Element_Is_Top_Of_The_Stack()  
        {
            // Arrange
            var stack = new MyStack(capacity: 10);

            // Act
            stack.WriteElement(1);
            stack.WriteElement(2);
            stack.WriteElement(3);
            stack.WriteElement(4);
            stack.WriteElement(5);

            // Assert
            Assert.AreEqual(5, stack.CheckElement());
        }
    }
}

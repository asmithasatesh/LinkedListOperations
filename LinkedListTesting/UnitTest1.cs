using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListOperations;

namespace LinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        OperationsOnLinkedList obj;
        [TestInitialize]
        public void SetUp()
        {
            obj = new OperationsOnLinkedList();
        }

        //USECASE 9- Search and Delete data 40 from Linked List
        [TestMethod]
        public void Usecase_9()
        {
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(40);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            int actualValue = obj.DeleteInBetween(40);
            int expectedValue = 3;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

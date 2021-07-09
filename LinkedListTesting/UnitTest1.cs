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

        //USECASE 8- Insert data 40 after 30
        [TestMethod]
        public void Usecase_8()
        {
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            int actualValue = obj.InsertInBetween(30,40);
            int expectedValue = 40;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

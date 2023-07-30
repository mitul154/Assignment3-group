using Assignment3;

namespace Assignment3.Tests
{
    public class SLLTests
    {
        private ILinkedListADT users;
        private User tempUser = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");


        [SetUp]
        public void Setup()
        {
            this.users = new SLL();
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(tempUser);
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        /// <summary>
        /// Tests the object was serialized.
        /// </summary>
        [Test]
        public void IsEmptyTest()
        {
            Assert.IsFalse(this.users.IsEmpty());
            users.Clear();
            Assert.IsTrue(this.users.IsEmpty());
        }

        [Test]
        public void AddFirstTest()
        {
            users.AddFirst(new User(0, "Jake", "jake@gmail.com", "password"));
            Assert.AreEqual(0, users.GetValue(0).Id);
            Assert.AreEqual(5, users.Count());
        }

        [Test]
        public void AddLastTest()
        {
            users.AddLast(new User(5, "Jake", "jake@gmail.com", "password"));
            Assert.AreEqual(4, users.GetValue(3).Id);
            Assert.AreEqual(5, users.GetValue(4).Id);
            Assert.AreEqual(1, users.GetValue(0).Id);
        }
        [Test]
        public void Add()
        {
            users.Add(new User(5, "Jake", "jake@gmail.com", "password"), 2);
            Assert.AreEqual("Jake", users.GetValue(2).Name);
            Assert.AreEqual("Colonel Sanders", users.GetValue(3).Name);
            Assert.AreEqual("Ronald McDonald", users.GetValue(4).Name);
        }

        [Test]
        public void RemoveTest()
        {
            users.Remove(1);
            Assert.AreEqual(3, users.Count());
            Assert.AreEqual(4, users.GetValue(2).Id);
            Assert.AreEqual(3, users.GetValue(1).Id);
        }

        [Test]
        public void ReplaceTest()
        {
            User newUser = new User(5, "Jake", "jake@gmail.com", "password");
            users.Replace(newUser, 1);
            Assert.AreEqual(4, users.Count());
            Assert.AreEqual(5, users.GetValue(1).Id);
            Assert.AreEqual(1, users.GetValue(0).Id);
            Assert.AreEqual(3, users.GetValue(2).Id);
            users.Replace(newUser, 0);
            Assert.AreEqual(5, users.GetValue(0).Id);
            Assert.AreEqual(5, users.GetValue(1).Id);
            Assert.AreEqual(3, users.GetValue(2).Id);

        }

        [Test]
        public void RemoveFirstTest()
        {
            users.RemoveFirst();
            Assert.AreEqual(3, users.Count());
            Assert.AreEqual(2, users.GetValue(0).Id);
        }

        [Test]
        public void RemoveLastTest()
        {
            users.RemoveLast();
            Assert.AreEqual(3, users.Count());
            Assert.AreEqual(3, users.GetValue(2).Id);
            Assert.IsNull(users.GetValue(3));
        }
        [Test]
        public void RetrieveTest()
        {
            Assert.IsTrue(users.Contains(tempUser));
            Assert.AreEqual(4, users.Count());
            Assert.AreEqual(2, users.GetValue(1).Id);
        }
    }
}
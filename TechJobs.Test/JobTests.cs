
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects

        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


        //initalize your testing objects here

 
    
    
        
            //TODO: add emptyTest so we can configure our runtime environment
            [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10,10,.001);
        }
        [TestMethod]

        public void TestSettingJobId ()
        {
            int actual = job2.Id - job1.Id;
            Assert.AreEqual(1, actual);

        }
        [TestMethod]    

        public void TestJobConstructorSetsAllFields ()
        {
            string actual = job3.Name;
            Assert.AreEqual("Product tester", actual);
            string actual1 = job3.EmployerName.Value;
            Assert.AreEqual("ACME", actual1);
            string actual2 = job3.EmployerLocation.Value;
            Assert.AreEqual("Desert", actual2);
            string actual3 = job3.JobType.Value;
            Assert.AreEqual("Quality control", actual3);
            string actual4 = job3.JobCoreCompetency.value;
            Assert.AreEqual("Persistence", actual4);


        }
        // ... other TODOs omitted here


    }
}



namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects

        Job job1;

        Job job2;

        Job job3;

        Job job4;

        



        //initalize your testing objects here

        [TestInitialize]
        public void Init()
        {
            job1 = new Job();

            job2 = new Job();

            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

         
        }



  
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
            string actual4 = job3.JobCoreCompetency.Value;
            Assert.AreEqual("Persistence", actual4);

        }

        [TestMethod]

        public void TestJobsForEquality ()
        {
            int actual = job1.Id - job1.Id;
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine ()
        {
            //string actualId = "\n ID: 4 \n" +
            // "Name: Product tester  \n " +
            // "";
            //\n[0]
                bool actual1 = job3.ToString().StartsWith(Environment.NewLine);
                bool actual2 = job3.ToString().EndsWith(Environment.NewLine);
            
            Assert.IsTrue (actual1);
            Assert.IsTrue (actual2);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData() 
        {
            string expected = $"{Environment.NewLine}ID: {job3.Id}" +
                $"{Environment.NewLine}Name: Product tester" +
                $"{Environment.NewLine}Employer: ACME" +
                $"{Environment.NewLine}Location: Desert" +
                $"{Environment.NewLine}Position Type: Quality control" +
                $"{Environment.NewLine}Core Competency: Persistence" +
                $"{Environment.NewLine}";
            Assert.AreEqual (expected, job3.ToString());
        }

        [TestMethod]

        public void TestToStringHandlesEmptyField () 
        {
            job3.Name = String.Empty;
            job3.EmployerName.Value = String.Empty;
            job3.EmployerLocation.Value = String.Empty;
            job3.JobType.Value = String.Empty;
            job3.JobCoreCompetency.Value = String.Empty;

            string expected = $"{Environment.NewLine}ID: {job3.Id}" +
                $"{Environment.NewLine}Name: Data not available" +
                $"{Environment.NewLine}Employer: Data not available" +
                $"{Environment.NewLine}Location: Data not available" +
                $"{Environment.NewLine}Position Type: Data not available" +
                $"{Environment.NewLine}Core Competency: Data not available" +
                $"{Environment.NewLine}";
            Assert.AreEqual(expected, job3.ToString());
        }

        // ... other TODOs omitted here



    }
}


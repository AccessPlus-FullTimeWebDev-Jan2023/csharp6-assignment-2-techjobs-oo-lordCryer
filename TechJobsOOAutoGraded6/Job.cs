using System;
namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this() 

        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  


        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.

        public override string ToString()
        {
            string buildString = $"{Environment.NewLine}ID: {Id}";
            if (Name == null || Name == String.Empty)
            {
              buildString +=  $"{Environment.NewLine}Name: Data not available";
            } else
            {
                buildString += $"{Environment.NewLine}Name: {Name}";
            }

            if (EmployerName.Value == null || EmployerName.Value == String.Empty)
            {
                buildString += $"{Environment.NewLine}Employer: Data not available";
            }
            else
            {
                buildString += $"{Environment.NewLine}Employer: {EmployerName.Value}";
            }

            if (EmployerLocation.Value == null || EmployerLocation.Value == String.Empty)
            {
                buildString += $"{Environment.NewLine}Location: Data not available";
            }
            else
            {
                buildString += $"{Environment.NewLine}Location: {EmployerLocation.Value}";
            }

            if (JobType.Value == null || JobType.Value == String.Empty)
            {
                buildString += $"{Environment.NewLine}Position Type: Data not available";
            }
            else
            {
                buildString += $"{Environment.NewLine}Position Type: {JobType.Value}";
            }

            if (JobCoreCompetency.Value == null || JobCoreCompetency.Value == String.Empty)
            {
                buildString += $"{Environment.NewLine}Core Competency: Data not available" +
                    $"{Environment.NewLine}";
            }
            else
            {
                buildString += $"{Environment.NewLine}Core Competency: {JobCoreCompetency.Value}" +
                    $"{Environment.NewLine}";
            }

            return buildString;
                 
          
           
        }

        

        //Until you create this method, you will not be able to print a job to the console.



    }
}


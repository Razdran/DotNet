using System;

namespace Product.Data
{
    public abstract class Employee
    {
        public string Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; private set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public bool IsActive()
        {
            if (DateTime.Compare(DateTime.Now, EndDate) < 0)
                return true;
            return false;
        }

    }
}

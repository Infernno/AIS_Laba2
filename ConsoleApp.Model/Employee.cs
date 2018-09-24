namespace ConsoleApp.Model
{
    /// <summary>
    /// Модель, описывающая сотрудника организации
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// ID сотрудника
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        public int Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string fullname, string position, int salary)
        {
            Fullname = fullname;
            Position = position;
            Salary = salary;
        }

        public Employee(int id, string fullname, string position, int salary)
        {
            ID = id;
            Fullname = fullname;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"#{ID} - {Fullname} - {Position} - {Salary}$";
        }
    }
}


using System;

namespace comparisonT
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            // Se o salário for igual então faz a ordenação alfabética [A a Z]
            if (this.Salary == other.Salary)
                return other.Name.CompareTo(Name);

            // Ordenação padrão: do maior para o menor salário
            return other.Salary.CompareTo(Salary);
        }

        public override string ToString()
        {
            return this.Salary.ToString("C") + " - " + this.Name;
        }
    }
}

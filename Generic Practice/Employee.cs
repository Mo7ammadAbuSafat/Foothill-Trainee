namespace Generic_Practice
{
    public class Employee : BaseItem
    {
        private string name;

        public Employee(int id,string name)
        {
            this.Id = id;
            this.name = name;

        }

        public override string ToString() => $"id is {Id} and name is {name}";

    }
}

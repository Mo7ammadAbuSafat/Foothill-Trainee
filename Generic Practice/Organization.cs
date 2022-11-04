namespace Generic_Practice
{
    public class Organization : BaseItem
    {
        private string name;

        public Organization(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return ($"id is {Id} and name is {name}");
        }

    }
}

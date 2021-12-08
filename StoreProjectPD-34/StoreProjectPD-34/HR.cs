namespace StoreProjectPD_34
{
    class HR : Person, IId
    {
        public HR(string name, string surName, int age) : base(name, surName, age)
        {

        }

        public int Id { get; set; }
    }
}

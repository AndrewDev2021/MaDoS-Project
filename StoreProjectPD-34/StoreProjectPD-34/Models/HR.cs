using StoreProjectPD_34.Models.Common;

namespace StoreProjectPD_34.Models
{
    class HR : Person, IId
    {
        public HR(string name, string surName, int age) : base(name, surName, age)
        {

        }

        public int Id { get; set; }
    }
}

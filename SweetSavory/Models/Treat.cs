using System.Collections.Generic;
namespace SweetSavory.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }
        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public string TreatDescription { get; set; }

        public ICollection<FlavorTreat> Flavors { get; }
    }
}
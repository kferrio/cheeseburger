using System.Collections.Generic;

namespace Cheeseburger.Domain
{
    public class TargetClass
    {

        public TargetClass()
        {
            Fields = new List<TargetField>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TargetField> Fields { get; set; }
    }
}

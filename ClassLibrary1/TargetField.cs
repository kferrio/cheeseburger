namespace Cheeseburger.Domain
{
    public class TargetField
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual TargetClass TargetClass { get; set; }
    }
}

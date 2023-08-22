namespace Sandbox.Server.Models
{
    public class E
    {
        public int Id { get; set; }
        public string e1 { get; set; }
        public string e2 { get; set; }
        public string e3 { get; set; }

        public string e4 { get; set; }
        public string e5 { get; set; }

        public ICollection<D> dCol { get; set; }
    }
}

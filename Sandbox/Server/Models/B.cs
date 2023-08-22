namespace Sandbox.Server.Models
{
    public class B
    {
        public int Id { get; set; }
        public string b1 { get; set; }
        public string b2 { get; set; }
        public string b3 { get; set; }

        public string b4 { get; set; }
        public string b5 { get; set; }

        public ICollection<C> CCol { get; set; }

        public ICollection<E> ECol { get; set; }
    }
}

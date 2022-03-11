namespace Maverick.Books.Domain
{
    public class Autor : Entity
    {
        public Autor(string name)
        {
            Name = name;
            GenerateNewIdentity();
        }
        public string Name { get; protected set; }
    }
}

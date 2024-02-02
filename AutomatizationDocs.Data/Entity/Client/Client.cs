namespace AutomatizationDocs.Data.Entity.Client
{
    public class Client
    {
        public Guid Id { get; set; }

        public FullName FullName { get; set; }

        public Adress Adress { get; set; }

        public Passport Passport { get; set; }

        public IdNumber? IdNumber { get; set; }

        public Dictionary<string, string> OtherConnections { get; set; }

        public Guid IdentityUser { get; set; }




    }
}

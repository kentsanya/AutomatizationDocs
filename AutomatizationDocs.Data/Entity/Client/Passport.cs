
namespace AutomatizationDocs.Data.Entity.Client
{
    public class Passport
    {
        public Guid Id { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string? Series { get; set; }

        public string Number { get; set; }

        public DateOnly Date { get; set; }

        public string Organization { get; set; }
    }
}

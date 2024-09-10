
namespace SingleResponsibilityPrinciple
{
    public class PartnerWithoutSolid
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PartnerWithoutSolid(string name)
        {
            Name = name;
        }

        public void Register()
        {
            if (ValidatePartner())
            {
                Id = new Random().Next();

                RegisterAddress();

                SendEmail();

                Console.WriteLine("Parceiro cadastrado com sucesso! (Sem Solid)");
            }
        }

        private void SendEmail()
        {
            throw new NotImplementedException();
        }

        private void RegisterAddress()
        {
            throw new NotImplementedException();
        }

        private bool ValidatePartner()
        {
            throw new NotImplementedException();
        }
    }
}

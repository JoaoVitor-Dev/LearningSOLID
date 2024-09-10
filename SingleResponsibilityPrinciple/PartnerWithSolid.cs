using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class PartnerWithSolid
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PartnerWithSolid(string name)
        {
            Name = name;
        }

        public void Register()
        {
            var validation = new Validation();

            if (validation.ValidatePartner())
            {
                Id = new Random().Next();

                var address = new Address();
                address.Register();

                var email = new Email();
                email.SendEmail();

                Console.WriteLine("Parceiro cadastrado com sucesso! (Sem Solid)");
            }
        }
    }
}

using System.Text;

namespace EnumeracoesEComposicoes.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cliente: ");
            sb.Append(Name);
            sb.Append(" (");
            sb.Append(BirthDate.Date.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.Append(Email);

            return sb.ToString();
        }
    }
}

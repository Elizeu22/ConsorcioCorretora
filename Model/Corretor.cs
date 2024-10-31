using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corretora_Consorcio.Model
{
    public class Corretor
    {

        [Key]
        [Required]
        public long IdCnpj { get; set; }


        [Required]
        public string nome { get; set; }

        public ICollection<CorretoraCadastro> CorretoraCadastro { get; set; }

    }
}

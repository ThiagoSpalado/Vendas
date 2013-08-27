using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PessoaDTO
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string PCM { get; set; }
        public string Observacao { get; set; }
        public bool FlagAtiva { get; set; }
        public bool FlagInadiplente { get; set; }
    }
}
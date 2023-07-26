using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SWE.Identidade.Web.Models
{
    public class UsuarioRegistro
    {
        [Required(ErrorMessage =" O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="O campo {0} está em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatoio")]
        [StringLength(100,ErrorMessage ="O campo {0} precisa conter entre {2} e {1} caracter.")]
        public string Password { get; set; }

        [DisplayName("Confirme sua senha")]
        [Compare("Passwor",ErrorMessage ="As senhas não conferem.")]
        public string ConfirmedPassword { get; set; }
    }
    public class UsuarioLogin
    {
        [Required(ErrorMessage = " O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatoio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {2} e {1} caracter.")]
        public string Password { get; set; }
    }
}

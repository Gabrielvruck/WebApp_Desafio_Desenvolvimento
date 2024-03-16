using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class DepartamentoViewModel
    {
        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Descricao")]
        [DataMember(Name = "Descricao")]
        [StringLength(100, ErrorMessage = "O campo Descrição deve ter no máximo 100 caracteres.")]
        public string Descricao { get; set; }

    }
}

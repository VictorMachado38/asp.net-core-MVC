
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

//// Nos projetos no estilo SDK como este, vários atributos de assembly que sempre eram
//// definidos nesse arquivo agora são adicionados automaticamente durante o build e
//// populados com os valores definidos nas propriedades do projeto. Para obter detalhes
//// de quais atributos são incluídos e como personalizar esse processo, confira: https://aka.ms/assembly-info-properties


//// A definição de ComVisible como false torna os tipos neste assembly invisíveis para
//// os componentes do COM. Se for necessário acessar um tipo do COM neste assembly,
//// defina o atributo ComVisible como true nesse tipo.

//[assembly: ComVisible(false)]

////// O GUID a seguir será destinado à ID de typelib se este projeto for exposto ao COM.

//[assembly: Guid("af864403-4228-4d95-b651-fa78d9077c47")]

////[Column(TypeName = "Decimal(18,2)]


namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }


        [StringLength(100)]
        public string Nome { get; set; }


        [StringLength(100)]
        public string DescricaoCurta { get; set; }


        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }



        [Column(TypeName = "decimal(18,2")]
        public decimal Preco { get; set; }


        [StringLength(200)]
        public string ImagemUrl { get; set; }


        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
       // public object LanchesId { get; internal set; }
    }

}

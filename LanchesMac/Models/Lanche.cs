using System.Runtime.InteropServices;

// Nos projetos no estilo SDK como este, vários atributos de assembly que sempre eram
// definidos nesse arquivo agora são adicionados automaticamente durante o build e
// populados com os valores definidos nas propriedades do projeto. Para obter detalhes
// de quais atributos são incluídos e como personalizar esse processo, confira: https://aka.ms/assembly-info-properties


// A definição de ComVisible como false torna os tipos neste assembly invisíveis para
// os componentes do COM. Se for necessário acessar um tipo do COM neste assembly,
// defina o atributo ComVisible como true nesse tipo.

[assembly: ComVisible(false)]

//// O GUID a seguir será destinado à ID de typelib se este projeto for exposto ao COM.

[assembly: Guid("af864403-4228-4d95-b651-fa78d9077c47")]

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        public string Nome { get; set; }

        public string DescricaoCurta { get; set; }

        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }

        public bool EmEstodque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }

}

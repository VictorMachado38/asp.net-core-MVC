#pragma checksum "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3160c24f2ec68027a59a2ea0ac32ba4a07ce69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CheckoutCompleto), @"mvc.1.0.view", @"/Views/Pedido/CheckoutCompleto.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3160c24f2ec68027a59a2ea0ac32ba4a07ce69", @"/Views/Pedido/CheckoutCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f294bbb7b93fe52c26dc65ee51985218c04b612b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CheckoutCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <h2 style=\"text-align: center;\">");
#nullable restore
#line 4 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                   Write(ViewBag.CheckoutCompletoMensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n        <br />\r\n        <h2>Obriado pela compra:<strong>");
#nullable restore
#line 7 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                   Write(ViewBag.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        <br />\r\n        <h2>Número do pedido:<strong>");
#nullable restore
#line 9 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                Write(ViewBag.NumeroPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        <br />\r\n        <h2>Horario do pedido: <strong>");
#nullable restore
#line 11 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                  Write(ViewBag.DataPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        <br />\r\n        <h2>Valor: R$<strong> ");
#nullable restore
#line 13 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                         Write(ViewBag.TotalPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        <br />\r\n        <hr>\r\n        <h2>Quantidad: <strong>");
#nullable restore
#line 16 "C:\Users\Machado\Documents\MeusProjetos\_mvc\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                          Write(ViewBag.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
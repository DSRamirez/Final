#pragma checksum "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddbb55942e124a69a32a65f9329ad03cb45addca"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ezetr\Documents\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<body><header id=\"header\"><div class=\"center\"><div id=\"logo\"><img src=\"images/logo.jpg\" class=\"app-logo\" alt=\"Logotipo\"></div></div></header>\r\n\r\n    <div><section id=\"contenido\"><div><br>\r\n                <br>\r\n                <h1>SERVICIOS LE COIFFEUR</h1></div>\r\n\r\n            <article class=\"lavado\"><br>\r\n                <br>\r\n                <h1 class=\"subheader\">Lavados</h1>\r\n                <br>\r\n                <div class=\"image-lavado\"><img src=\"images/lavado.gif\" alt=\"lavado\"></div>\r\n                <br>\r\n                <p>\r\n                    El primero de los servicios, el más importante.\r\n                    Lavarte el cabello previo a un corte o peinado y/o luego de una coloración: hace al inicio y/o la finalización perfecta de tu experiencia en Le Coiffeur.\r\n                    Contamos con las mejores manos en nuestro equipo y una amplia variedad de marcas Premium que te garantizan un momento único.\r\n                    Las grandes marcas de la cosmética argentina, francesa, británica, italiana entre otras, dan garantía de formación para la persona que te lavará el pelo y un producto a medida según deseo y necesidad.\r\n                    Contarás con el asesoramiento preciso sobre tu cuero cabelludo y pelo para lograr la excelencia y confort que necesitas.\r\n                    No te pierdas una de las mejores experiencias en Le Coiffeur.\r\n                </p>\r\n                <br></article>\r\n\r\n            <article class=\"corte\"><br>\r\n                <br>\r\n                <h1 class=\"subheader\">Cortes</h1>\r\n                <br>\r\n                <div class=\"image-corte\"><img src=\"images/corte.gif\" alt=\"corte\"></div>\r\n                <br>\r\n                <p>\r\n                    Tijeras, máquinas, varios filos, precisión, técnica y sobre todo un estilo único hacen fundamental el Corte en Le Coiffeur.\r\n                    ¡Nuestro equipo de profesionales podrá asesorarte y hacer lucir tu pelo con el look ideal! El pelo es el accesorio más importante que tenemos.\r\n                    El Team de Le Coiffeur de corte y peinado está en constante perfeccionamiento sobre nuevas técnicas y tendencias. No dudes en dejarte asesorar.\r\n                    Cada uno de ellos se destaca en poder interpretar tu deseo y adaptarlo para un fácil y práctico día a día.\r\n                    Nuestro corte es diseñado exclusivamente para vos y tu vida cotidiana.\r\n                </p>\r\n                <br></article>\r\n\r\n            <article class=\"peinados\"><br>\r\n                <br>\r\n                <h1 class=\"subheader\">Peinados</h1>\r\n                <br>\r\n                <div class=\"image-peinados\"><img src=\"images/peinado.gif\" alt=\"peinado\"></div>\r\n                <br>\r\n                <p>\r\n                    Existe una amplia forma de llegar a tu peinado, Brushing, planchitas, ondas, y muchos más.\r\n                </p>\r\n                <br></article>\r\n\r\n            <article class=\"coloracion\"><br>\r\n                <br>\r\n                <h1 class=\"subheader\">Coloracion</h1>\r\n                <br>\r\n                <div class=\"image-coloracion\"><img src=\"images/coloracion.gif\" alt=\"coloracion\"></div>\r\n                <br>\r\n                <p>\r\n                    El servicio de color es un universo infinito dentro de nuestro salón.\r\n                    Nuestra marca cuenta con el mejor equipo de coloristas del país. Nos perfeccionamos constantemente para poder abordar todas tus necesidades.\r\n                    Te asesoramos de una manera minuciosa para poder aconsejarte sobre qué es lo que tu cabello necesita.\r\n                    Cuáles son los pasos que llevara tu pelo para llegar al objetivo que deseas.\r\n                    Nuestra misión fundamental es mantener tu pelo sano y que luzca intacto, garantizamos tu felicidad absoluta.\r\n                    Como expresamos anteriormente, el universo de color es inmenso e infinito, por eso y para orientarte, te invitamos a que leas atentamente cada una de las descripciones de toda nuestra carta de servicios en color que tenemos para lograr satisfacer tus necesidades.\r\n                </p>\r\n                <br></article></section></div>\r\n\r\n    <footer id=\"footer\"><div class=\"center\"><br>\r\n            <p>\r\n                &copy; Le Coiffeur\r\n            </p></div></footer></body>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

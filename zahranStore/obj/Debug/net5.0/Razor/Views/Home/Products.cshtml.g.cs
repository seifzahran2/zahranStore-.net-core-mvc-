#pragma checksum "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a230bbedf23c415c5bb0b9586d7c6100ecbced51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Products), @"mvc.1.0.view", @"/Views/Home/Products.cshtml")]
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
#line 1 "E:\projects\zahranStore\zahranStore\Views\_ViewImports.cshtml"
using zahranStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\zahranStore\zahranStore\Views\_ViewImports.cshtml"
using zahranStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a230bbedf23c415c5bb0b9586d7c6100ecbced51", @"/Views/Home/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea32b41136acf7c7b1afce0db8a5e2865955272", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<zahranStore.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section id=""services"" class=""services section-bg"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
          <h2>منتجات</h2>
          <p>نحن في خدمتكم طوال اليوم</p>
        </div>

        <div class=""row gy-4"">
");
#nullable restore
#line 12 "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div  class=\"col-lg-4 col-md-6 d-flex align-items-stretch\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n                <div style=\"width: 430px;\" class=\"icon-box iconbox-blue\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 577, "\"", 584, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                  <img style=\"border-radius:20%;border:7px solid #5e8ea0;\r\n                      width:400px;height:400px  \"");
            BeginWriteAttribute("src", "\r\n                  src=\"", 716, "\"", 755, 2);
            WriteAttributeValue("", 741, "../", 741, 3, true);
#nullable restore
#line 19 "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml"
WriteAttributeValue("", 744, item.Photo, 744, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                  <h4>");
#nullable restore
#line 20 "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                  <p>");
#nullable restore
#line 21 "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml"
                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n               </div>\r\n");
#nullable restore
#line 24 "E:\projects\zahranStore\zahranStore\Views\Home\Products.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n      </div>\r\n    </section><!-- End Services Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<zahranStore.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

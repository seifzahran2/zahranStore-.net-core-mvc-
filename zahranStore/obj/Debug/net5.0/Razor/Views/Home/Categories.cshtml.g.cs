#pragma checksum "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929278bfe7a4595e60595c6588f6c871faaf1daf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categories), @"mvc.1.0.view", @"/Views/Home/Categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929278bfe7a4595e60595c6588f6c871faaf1daf", @"/Views/Home/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea32b41136acf7c7b1afce0db8a5e2865955272", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""services"" class=""services section-bg"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
          <h2>اختار نوع المنتج</h2>
          <p>تسوق من منزلك من خلال موقعنا</p>
        </div>

        <div class=""row gy-4"">
");
#nullable restore
#line 12 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div  class=\"col-lg-4 col-md-6 d-flex align-items-stretch\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n                <div style=\"width: 430px;\" class=\"icon-box iconbox-blue\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 568, "\"", 598, 2);
            WriteAttributeValue("", 575, "/Home/Products/", 575, 15, true);
#nullable restore
#line 16 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
WriteAttributeValue("", 590, item.Id, 590, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"border-radius:20%;border:7px solid #5e8ea0;\r\n                      width:400px;height:400px  \"");
            BeginWriteAttribute("src", "\r\n                      src=\"", 706, "\"", 749, 2);
            WriteAttributeValue("", 735, "../", 735, 3, true);
#nullable restore
#line 18 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
WriteAttributeValue("", 738, item.Photo, 738, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                  <h4><a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 813, 2);
            WriteAttributeValue("", 790, "/Home/Products/", 790, 15, true);
#nullable restore
#line 19 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
WriteAttributeValue("", 805, item.Id, 805, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                  <p><a");
            BeginWriteAttribute("href", " href=\"", 859, "\"", 889, 2);
            WriteAttributeValue("", 866, "/Home/Products/", 866, 15, true);
#nullable restore
#line 20 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
WriteAttributeValue("", 881, item.Id, 881, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                </div>\r\n               </div>\r\n");
#nullable restore
#line 23 "E:\projects\zahranStore\zahranStore\Views\Home\Categories.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
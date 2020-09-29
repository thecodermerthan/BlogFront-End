#pragma checksum "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41fac002b7e8da1ff26b9d95bd4bf51cf2b55c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlogFront.Models.Home.Views_Home_BlogDetail), @"mvc.1.0.view", @"/Views/Home/BlogDetail.cshtml")]
namespace BlogFront.Models.Home
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
#line 2 "C:\Users\merth\BlogFront\Views\_ViewImports.cshtml"
using BlogFront.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41fac002b7e8da1ff26b9d95bd4bf51cf2b55c48", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92e9c9f60ff8e848a859be7cb0541553e24853f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::BlogFront.TagHelpers.ImageTagHelper __BlogFront_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Title -->\r\n        <h1 class=\"mt-4\">");
#nullable restore
#line 3 "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml"
                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        <!-- Author -->\r\n");
            WriteLiteral("\r\n        <hr>\r\n\r\n        <!-- Date/Time -->\r\n        <p>Posted on ");
#nullable restore
#line 14 "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml"
                Write(Model.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <hr>\r\n\r\n        <!-- Preview Image -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fac002b7e8da1ff26b9d95bd4bf51cf2b55c483819", async() => {
            }
            );
            __BlogFront_TagHelpers_ImageTagHelper = CreateTagHelper<global::BlogFront.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__BlogFront_TagHelpers_ImageTagHelper);
#nullable restore
#line 19 "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml"
__BlogFront_TagHelpers_ImageTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __BlogFront_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml"
__BlogFront_TagHelpers_ImageTagHelper.BlogImageType = BlogImageType.BlogDetail;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("blog-image-type", __BlogFront_TagHelpers_ImageTagHelper.BlogImageType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n");
            WriteLiteral("\r\n        <hr>\r\n\r\n        <!-- Post Content -->\r\n        ");
#nullable restore
#line 26 "C:\Users\merth\BlogFront\Views\Home\BlogDetail.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <hr>\r\n\r\n        <!-- Comments Form -->\r\n        <div class=\"card my-4\">\r\n          <h5 class=\"card-header\">Leave a Comment:</h5>\r\n          <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fac002b7e8da1ff26b9d95bd4bf51cf2b55c486030", async() => {
                WriteLiteral("\r\n              <div class=\"form-group\">\r\n                <textarea class=\"form-control\" rows=\"3\"></textarea>\r\n              </div>\r\n              <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n\r\n        <!-- Single Comment -->\r\n        <div class=\"media mb-4\">\r\n          <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 1250, "\"", 1256, 0);
            EndWriteAttribute();
            WriteLiteral(@">
          <div class=""media-body"">
            <h5 class=""mt-0"">Commenter Name</h5>
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
          </div>
        </div>

        <!-- Comment with nested comments -->
        <div class=""media mb-4"">
          <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 1809, "\"", 1815, 0);
            EndWriteAttribute();
            WriteLiteral(@">
          <div class=""media-body"">
            <h5 class=""mt-0"">Commenter Name</h5>
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.

            <div class=""media mt-4"">
              <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 2295, "\"", 2301, 0);
            EndWriteAttribute();
            WriteLiteral(@">
              <div class=""media-body"">
                <h5 class=""mt-0"">Commenter Name</h5>
                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
              </div>
            </div>

            <div class=""media mt-4"">
              <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 2835, "\"", 2841, 0);
            EndWriteAttribute();
            WriteLiteral(@">
              <div class=""media-body"">
                <h5 class=""mt-0"">Commenter Name</h5>
                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
              </div>
            </div>

          </div>
        </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

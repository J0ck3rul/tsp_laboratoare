#pragma checksum "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7637cd63cf4540eb07ed3b73243055655b586a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MediaRazorPage.Pages.Photos.Pages_Photos_Index), @"mvc.1.0.razor-page", @"/Pages/Photos/Index.cshtml")]
namespace MediaRazorPage.Pages.Photos
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
#line 1 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\_ViewImports.cshtml"
using MediaRazorPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7637cd63cf4540eb07ed3b73243055655b586a", @"/Pages/Photos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c5c13344027044bc2f3b3eedba1dd0268404a8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sp-page", new global::Microsoft.AspNetCore.Html.HtmlString("./Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Photos</h1>\r\n<br />\r\n<br />\r\n<div class=\"container\" style=\"display:flex; width=100%\">\r\n    <div class=\"left-side\" style=\"border:1px dotted #1861ac;\">\r\n        <h2>Photos</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7637cd63cf4540eb07ed3b73243055655b586a4111", async() => {
                WriteLiteral(@"
            <div style=""display:flex;flex-direction:column;justify-content:center;padding: 8px"">
                <div style=""display:flex;justify-content:space-evenly"">
                    <div class=""form-group"">
                        <label class=""control-label"">Name</label>
                        <input class=""form-control"" name=""name"" />
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Tag</label>
                        <input class=""form-control"" name=""tag"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Photo Id Tags</label>
                        <input class=""form-control"" name=""photoIdTag"" />
                    </div>
                </div>

                <div style=""display: flex; align-items: center; margin-top: 8px; justify-content: center"">
                    <input type=""submit"" value=""Filter"" class=""btn btn-prim");
                WriteLiteral("ary\">\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <p>Numbers results: ");
#nullable restore
#line 38 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayTextFor(model => model.Items.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 48 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 51 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items[0].Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 54 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items[0].Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 57 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items[0].Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Go to\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"font-size: small\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""right-side"" style=""margin-left:50px;border:1px dotted #1861ac;"">
        <h2>Tags</h2>



        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 94 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tags[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 97 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tags[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 100 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tags[0].PhotoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 106 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                 foreach (var item in Model.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"font-size: small\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 110 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 113 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 116 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhotoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 120 "C:\Users\etibulea\source\repos\Tsp\MediaRazorPage\Pages\Photos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaRazorPage.Pages.Photos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaRazorPage.Pages.Photos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaRazorPage.Pages.Photos.IndexModel>)PageContext?.ViewData;
        public MediaRazorPage.Pages.Photos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f0363ad1f62bab33d0eabe5cd4e2f3859edb53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Basket), @"mvc.1.0.view", @"/Views/Shop/Basket.cshtml")]
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
#line 3 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f0363ad1f62bab33d0eabe5cd4e2f3859edb53", @"/Views/Shop/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fe441d203ed8e56268dd43a356fb70c287ee5c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Basket>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("shipping cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prd-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin:50px 0px;"" class=""page-contain shopping-cart"">

        <!-- Main content -->
        <div id=""main-content"" class=""main-content"">
            <div class=""container"">
                <h2 style=""margin-bottom:20px;"">Basket</h2>
                <!--Top banner-->
            <div class=""bbasket"">
                <div class=""bb-left"">
                   
");
#nullable restore
#line 17 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 539, "\"", 595, 4);
            WriteAttributeValue("", 547, "bb-product", 547, 10, true);
            WriteAttributeValue(" ", 557, "cart_item", 558, 10, true);
            WriteAttributeValue(" ", 567, "basket-item-", 568, 13, true);
#nullable restore
#line 19 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
WriteAttributeValue("", 580, item.ProductId, 580, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\n                        <div class=\"bb-one\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f0363ad1f62bab33d0eabe5cd4e2f3859edb536586", async() => {
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "75f0363ad1f62bab33d0eabe5cd4e2f3859edb536875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 795, "~/uploads/images/", 795, 17, true);
#nullable restore
#line 22 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
AddHtmlAttributeValue("", 812, item.Product.Images.FirstOrDefault()?.Name, 812, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                        <div class=\"bb-two\">\n                            \n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f0363ad1f62bab33d0eabe5cd4e2f3859edb5310717", async() => {
#nullable restore
#line 27 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                                                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""ccount"">
                                    <p>Count</p>
                                    <div class=""quantity-box type1"">
                                        <div class=""qty-input"">
                                            
                                            <input type=""number"" data-product-id=""");
#nullable restore
#line 33 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                             Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onchange=\"changeQuantity(event,this)\" min=\"1\"");
            BeginWriteAttribute("value", " value=\"", 1583, "\"", 1605, 1);
#nullable restore
#line 33 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
WriteAttributeValue("", 1591, item.Quantity, 1591, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        </div>
                                    </div>
                                    

                            </div>
                                <span class=""price-amount"">Price: <span class=""currencySymbol"">$</span>");
#nullable restore
#line 39 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                                                  Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                <br></br>\n                                <span class=\"price-amount\">Total Price: <span class=\"currencySymbol\">$</span>");
#nullable restore
#line 41 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                                                                         Write((item.Product.Price * item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"bb-three\">\n                                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2222, "\"", 2283, 4);
            WriteAttributeValue("", 2232, "removeFromBasket(this,", 2232, 22, true);
            WriteAttributeValue(" ", 2254, "\'", 2255, 2, true);
#nullable restore
#line 44 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
WriteAttributeValue("", 2256, item.Product.Name, 2256, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2274, "\');return", 2274, 9, true);
            EndWriteAttribute();
            WriteLiteral("\n                                   data-product-id=\"");
#nullable restore
#line 45 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                               Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-remove-target", "\n                                   aria-remove-target=\"", 2353, "\"", 2437, 2);
            WriteAttributeValue("", 2409, ".basket-item-", 2409, 13, true);
#nullable restore
#line 46 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
WriteAttributeValue("", 2422, item.ProductId, 2422, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"remove\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\n                        </div>\n                    </div>\n");
#nullable restore
#line 49 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"bb-right\">\n                    <h3>Total</h3>\n                    \n                    <br>\n                    <span>Price of Products:</span>\n                    <span id=\"summary\" class=\"stt-price\">");
#nullable restore
#line 56 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Basket.cshtml"
                                                    Write(Model.Sum(m=>m.Quantity * m.Product.Price).ToString("0.00$"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>

                <!--Cart Table-->
              

                <!--Related Product-->
              
                        
                        
                        
                        
                        
                        
                  
                </div>

            </div>
        </div>
</div>



");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Basket>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

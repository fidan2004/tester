#pragma checksum "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376837b08a359fdcdf5f3d3224ce60f6ff0d7f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376837b08a359fdcdf5f3d3224ce60f6ff0d7f00", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fe441d203ed8e56268dd43a356fb70c287ee5c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Li's Content Wraper Area -->



<div class=""page-contain category-page left-sidebar"" style=""margin:30px 0px;"">
    <div class=""container"">
        <div class=""row"">
            <!-- Main content -->
            <div id=""main-content"" class=""main-content col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                <div class=""product-category grid-style"">
                    <div class=""row"">
                        <ul class=""products-list"">
                          
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "376837b08a359fdcdf5f3d3224ce60f6ff0d7f004570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>
            <!-- Sidebar -->
            <aside id=""sidebar"" class=""sidebar col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                <div class=""sidebar-contain"">
                    <div class=""widget biolife-filter"">
                        <h4 class=""wgt-title"">Departements</h4>
                        <div class=""wgt-content"">
                            <ul class=""cat-list"">
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button0"">All</button></li>
                                <hr/>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button2"">Man</button></li>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; bac");
            WriteLiteral(@"kground-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button3"">Shoes</button></li>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button4"">Jeans</button></li>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button5"">Coats</button></li>
                                <hr />
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button1"">Woman</button></li>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button6"">Bags</button></li>
                                <li class=""cat-list");
            WriteLiteral(@"-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button7"">Jackets</button></li>
                                <li class=""cat-list-item""><button style=""padding: 0px 30px; background-color: gray; color: white; border-radius: 10px; margin-bottom: 10px;"" id=""button8"">T-Shirts</button></li>
                               
                            </ul>
                        </div>
                    </div>


                </div>

            </aside>
        </div>
    </div>
</div>

<!-- Content Wraper Area End Here -->
");
            WriteLiteral("\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\n<script>\n\n        function goPage(pageIndex, pageSize) {\n\n        $.ajax({\n            url: `");
#nullable restore
#line 76 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shop\Index.cshtml"
             Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
            type: 'POST',
            data: {
                pageIndex: pageIndex,
                pageSize: pageSize
            },
            contentType:'application/x-www-form-urlencoded',
            success: function(response) {
                $('#dynamic-content').html(response);
                location.hash = ""#dynamic-content"";
                location.hash = """";
            },
            error: function(response) {
                console.log(response);
            }
        });
    }
        function addToFavorites(productId)
        {
            const favorites = ($.cookie('favorites') || '').split(',').filter(item => item.length > 0);

            if (favorites.filter(item => item == productId).length == 0)
            {
                favorites.push(productId);

                $.cookie('favorites',favorites.toString(),{ path: '/', expires:5 })
            }
            console.log($.cookie('favorites'));

        }

        const button1 = document.getElementById('button1');
        c");
                WriteLiteral(@"onst button2 = document.getElementById('button2');
        const button0 = document.getElementById('button0');
        const button3 = document.getElementById('button3');
        const button4 = document.getElementById('button4');
        const button5 = document.getElementById('button5');
        const button6 = document.getElementById('button6');
        const button7 = document.getElementById('button7');
        const button8 = document.getElementById('button8');


        const productItems = document.querySelectorAll('.product-item');

        button1.addEventListener('click', function () {
            hideProducts2('5');
        });

        button2.addEventListener('click', function () {
            hideProducts2('1');
        });
        button0.addEventListener('click', function () {
            showProducts('ALL');
        });
        button3.addEventListener('click', function () {
            hideProducts('SHOES');
        });

        button4.addEventListener('click', function () {
            hid");
                WriteLiteral(@"eProducts('JEANS');
        });
        button5.addEventListener('click', function () {
            hideProducts('COATS');
        });
        button6.addEventListener('click', function () {
            hideProducts('BAGS');
        });

        button7.addEventListener('click', function () {
            hideProducts('JACKETS');
        });
        button8.addEventListener('click', function () {
            hideProducts('T-SHIRTS');
        });

        function hideProducts(gender) {
            productItems.forEach(function (item) {
                const itemGender = item.getAttribute('data-gender');
                if (itemGender === gender) {
                    item.style.display = 'block';
                }
                if(itemGender != gender){
                    item.style.display = 'none';
                }
            });
        }
         function hideProducts2(id) {
            productItems.forEach(function (item) {
                const itemId = item.getAttribute('data-id');
                ");
                WriteLiteral(@"if (itemId === id) {
                    item.style.display = 'block';
                }
                if (itemId != id) {
                    item.style.display = 'none';
                }
            });
        }
        function showProducts(gender) {
            productItems.forEach(function (item) {
                    item.style.display = 'block';
                
            });
        }
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

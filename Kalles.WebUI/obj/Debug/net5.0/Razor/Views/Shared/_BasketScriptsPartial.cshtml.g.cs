#pragma checksum "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shared\_BasketScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c10a987b386a9186f1eb0670e7e6738c37dad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketScriptsPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketScriptsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c10a987b386a9186f1eb0670e7e6738c37dad8", @"/Views/Shared/_BasketScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fe441d203ed8e56268dd43a356fb70c287ee5c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BasketScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("removeable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.customize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c10a987b386a9186f1eb0670e7e6738c37dad85099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c10a987b386a9186f1eb0670e7e6738c37dad86223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c10a987b386a9186f1eb0670e7e6738c37dad87347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        function removeFromBasket(element, name) {

            swal(`Əminsiniz ki '${name}' silinsin?`, {
                title: ""Diqqət!"",
                text: `Əminsiniz ki '${name}' silinsin?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""Xeyr"", ""Bəli""],
            })
                .then((value) => {

                    if (value == true) {
                        const elementData = $(element).data();
                        console.log(elementData);

                        $.ajax({
                            url: `");
#nullable restore
#line 26 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shared\_BasketScriptsPartial.cshtml"
                             Write(Url.Action("RemoveFromBasket","Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                            type: 'POST',
                            data: elementData,
                            contentType: 'application/x-www-form-urlencoded',
                            success: function (response) {
                                if (response.error == false) {
                                    const removeTarget = $(element).attr('aria-remove-target');
                                    if(removeTarget != undefined ){
                                        $(removeTarget).remove();
                                    }

                                    if(response.value?.count == null){
                                        $('.qty').text('');
                                    }
                                    else{
                                        $('.qty').text(response.value.count);
                                    }
                                    
                                    toastr.success(response.message, 'Success');
                  ");
            WriteLiteral(@"                  return;
                                }

                                toastr.error(response.message, 'Error');
                            },
                            error: function (response, status, xhr) {
                                console.log(response, status, xhr);
                            }
                        });
                    }
                });



        }

        function changeQuantity(event, element) {

            if ($.processId != undefined) {
                clearTimeout($.processId);
                $.processId = undefined;
            }

            if (element.value < 1) {
                console.log('false!', element.value);

                return false;
            }

            $.processId = setTimeout(function () {

                const elementData = $(element).data();
                elementData.quantity = element.value;

                $.ajax({
                    url: `");
#nullable restore
#line 80 "C:\Users\Hp\Downloads\project-main\Kalles.WebUI\Views\Shared\_BasketScriptsPartial.cshtml"
                     Write(Url.Action("ChangeBasketQuantity","Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                    type: 'POST',
                    data: elementData,
                    contentType: 'application/x-www-form-urlencoded',
                    success: function (response) {
                        console.log(response);
                        if (response.error == false) {

                            $(element).closest('tr').find('.amount').text(`${response.value.price}$`);
                            $(element).closest('tr').find('.product-subtotal').text(`${response.value.total}$`);
                            $('#summary').text(`${response.value.summary}$`);
                            toastr.success(response.message, 'Success');
                            return;
                        }

                        toastr.error(response.message, 'Error');
                    },
                    error: function (response, status, xhr) {
                        console.log(response, status, xhr);
                    }
                });

            }, 800);


        }
    </sc");
            WriteLiteral("ript>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

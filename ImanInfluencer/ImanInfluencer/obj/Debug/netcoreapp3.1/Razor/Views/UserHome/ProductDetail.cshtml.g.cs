#pragma checksum "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHome_ProductDetail), @"mvc.1.0.view", @"/Views/UserHome/ProductDetail.cshtml")]
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
#line 1 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\_ViewImports.cshtml"
using ImanInfluencer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\_ViewImports.cshtml"
using ImanInfluencer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c5a5c661e6c8ae1f17e5ef61487c2e19c93c16", @"/Views/UserHome/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea5b59277d5a1fad60d2a183ba3ede725e8896d6", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHome_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<ImanInfluencer.Models.Product1, IEnumerable<ImanInfluencer.Models.Product1>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-109 cl8 hov-cl1 trans-04"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ph"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("IMG - PRODUCT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 40%;height: 40%; border-radius: 50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("IMG-PRODUCT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/vendor/jquery/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/vendor/MagnificPopup/jquery.magnific-popup.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- breadcrumb -->\r\n<div class=\"container\">\r\n    <div class=\"bread-crumb flex-w p-l-25 p-r-15 p-t-30 p-lr-0-lg\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c168955", async() => {
                WriteLiteral("\r\n            Home\r\n            <i class=\"fa fa-angle-right m-l-9 m-r-10\" aria-hidden=\"true\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1610522", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
       Write(ViewBag.categoryname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <i class=\"fa fa-angle-right m-l-9 m-r-10\" aria-hidden=\"true\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <span class=\"stext-109 cl4\">\r\n            ");
#nullable restore
#line 23 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
       Write(Model.Item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </span>
    </div>
</div>


<!-- Product Detail -->
<section class=""sec-product-detail bg0 p-t-65 p-b-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-7 p-b-30"">
                <div class=""p-l-25 p-r-30 p-lr-0-lg"">
                    <div class=""wrap-slick3 flex-sb flex-w"">
                        <div class=""wrap-slick3-dots""></div>
                        <div class=""wrap-slick3-arrows flex-sb-m flex-w""></div>

                        <div class=""slick3 gallery-lb"">

");
#nullable restore
#line 41 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                             foreach (var item in Model.Item1.Images)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item-slick3 slick-slide\" data-thumb=\"\">\r\n                                    <div class=\"wrap-pic-w pos-relative\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1613765", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1691, "~/Images/", 1691, 9, true);
#nullable restore
#line 45 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
AddHtmlAttributeValue("", 1700, item.Imagepath, 1700, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1615493", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-expand\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1863, "~/Images/", 1863, 9, true);
#nullable restore
#line 47 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
AddHtmlAttributeValue("", 1872, item.Imagepath, 1872, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 52 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 mt-5 "">
                <div class=""card"">
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1617863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2393, "~/Images/", 2393, 9, true);
#nullable restore
#line 63 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
AddHtmlAttributeValue("", 2402, Model.Item1.User.Imagepath, 2402, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h1 class=\"h2\">Name</h1>\r\n                        <p class=\"h3 py-2\">");
#nullable restore
#line 65 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                      Write(Model.Item1.User.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                                              Write(Model.Item1.User.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h1 class=\"h2\">Email</h1>\r\n                        <p class=\"h3 py-2\">");
#nullable restore
#line 67 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                      Write(Model.Item1.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h1 class=\"h2\">Phone</h1>\r\n                        <p class=\"h3 py-2\">");
#nullable restore
#line 69 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                      Write(Model.Item1.User.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>


                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-5 p-b-30"">
                <div class=""p-r-50 p-t-5 p-lr-0-lg"">
                    <h4 class=""mtext-105 cl2 js-name-detail p-b-14"">
                        ");
#nullable restore
#line 78 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                   Write(Model.Item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h4>\r\n\r\n                    <span class=\"mtext-106 cl2\">\r\n                        $<span> ");
#nullable restore
#line 82 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                           Write(Model.Item1.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>+20%tax
                    </span>

                    <p id=""desc"" class=""stext-102 cl3 p-t-23"">

                    </p>

                    <!--  -->
                    <div class=""p-t-33"">

                        <div class=""flex-w flex-r-m p-b-10"">
                            <div class=""size-204 flex-w flex-m respon6-next"">


                                <button");
            BeginWriteAttribute("onclick", " onclick=\'", 3723, "\'", 3759, 3);
            WriteAttributeValue("", 3733, "addtoCart(", 3733, 10, true);
#nullable restore
#line 96 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
WriteAttributeValue("", 3743, Model.Item1.Id, 3743, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3758, ")", 3758, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04 js-addcart-detail"">
                                    Add to Cart
                                </button>

                            </div>
                            <div id=""resultcart"" style=""color: green;""></div>

                        </div>
                        <div class=""form-group mb-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1623424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 105 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Paymentid;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""flex-w flex-r-m p-b-10"">
                            <div class=""size-204 flex-w flex-m respon6-next"">


                                <button onclick=""buyItem()"" class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04 "">
                                    Buy
                                </button>

                            </div>
                            <div id=""result"" style=""color: green;""></div>

                        </div>
                    </div>

                    <!--  -->
                    <div class=""flex-w flex-m p-l-100 p-t-40 respon7"">
                        <div class=""flex-m bor9 p-r-10 m-r-11"">
                            <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 js-addwish-detail tooltip100"" data-tooltip=""Add to Wishlist"">
                                <i class=""zmdi zmdi-favorite""></i>
                            </a>
                   ");
            WriteLiteral(@"     </div>

                        <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Facebook"">
                            <i class=""fa fa-facebook""></i>
                        </a>

                        <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Twitter"">
                            <i class=""fa fa-twitter""></i>
                        </a>

                        <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Google Plus"">
                            <i class=""fa fa-google-plus""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>




<!-- Related Products -->
<section class=""sec-relate-product bg0 p-t-45 p-b-105"">
    <div class=""container"">
        <div class=""p-b-45"">
            <h3 class=""ltext-106 cl5 txt-center"">
               ");
            WriteLiteral(" Related Products\r\n            </h3>\r\n        </div>\r\n\r\n        <div class=\"wrap-slick2\">\r\n            <div class=\"slick2\">\r\n\r\n");
#nullable restore
#line 162 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                 foreach (var item in Model.Item2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""item-slick2 p-l-15 p-r-15 p-t-15 p-b-15"">
                        <!-- Block2 -->
                        <div class=""block2"">
                            <div class=""block2-pic hov-img0"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1627878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6776, "~/Images/", 6776, 9, true);
#nullable restore
#line 168 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
AddHtmlAttributeValue("", 6785, item.Images.FirstOrDefault().Imagepath, 6785, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\'", 6882, "\'", 6912, 3);
            WriteAttributeValue("", 6892, "redirect(\"", 6892, 10, true);
#nullable restore
#line 170 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
WriteAttributeValue("", 6902, item.Id, 6902, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6910, "\")", 6910, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1"">
                                    View
                                </a>
                            </div>

                            <div class=""block2-txt flex-w flex-t p-t-14"">
                                <div class=""block2-txt-child1 flex-col-l "">
                                    <a href=""#"" class=""stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6"">
                                        ");
#nullable restore
#line 178 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n\r\n                                    <span class=\"stext-105 cl3\">\r\n                                        $");
#nullable restore
#line 182 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" +20%tax\r\n                                    </span>\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 190 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1631892", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c5a5c661e6c8ae1f17e5ef61487c2e19c93c1632933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    $(window).on('load', function () {
        let ph = $('.ph');
        let smallpicture = $('.cartitem');

        for (var i = 0; i < smallpicture.length; i++) {
            var temp = $(ph[i]).attr('src');
            $(smallpicture[i]).attr('src', temp);
            console.log(""small"" + $(smallpicture[i]).attr('src'));
            console.log(""ph"" + $(ph[i]).attr('src'));

        }
    });








    function addtoCart(parm) {
        var result = document.getElementById(""resultcart"");

         $.ajax({
            type: ""POST"",
             url: '");
#nullable restore
#line 233 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
              Write(Url.Action("AddtoCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: { id: parm },
            dataType: ""json"",
             success: function (msg) {
                 console.log(msg);
                 if (msg == ""1"")
                     result.innerHTML = ""Your order was submited"";
                 else if (msg == ""0"")
                     result.innerHTML = ""already exist in cart"";
                 
             },
             error: function (req, status, error) {
                 console.log(req);
                 console.log(status);
                 console.log(error);


             }
         });


    }



    function buyItem() {

        var result = document.getElementById(""result"");
        var payment = document.getElementById(""payment"").value;

        $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 265 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
             Write(Url.Action("AddItem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: { sellerid: \"");
#nullable restore
#line 266 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                          Write(Model.Item1.Userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", productid: \"");
#nullable restore
#line 266 "C:\Users\kamel\Desktop\Training\ImanInfluencer\ImanInfluencer\ImanInfluencer\Views\UserHome\ProductDetail.cshtml"
                                                            Write(Model.Item1.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", payment: payment },
            dataType: ""text"",
            success: function (msg) {
            console.log(msg);
            if (msg == ""1"")
            result.innerHTML = ""Your order was submited"";
            else if(msg == ""0"")
            result.innerHTML = ""Your alredy made that action "";
            else if (msg == ""2"")
            result.innerHTML = ""You dont have enough money"";


            },
            error: function (req, status, error) {
            console.log(msg);
            result.innerHTML = ""<span style='color : \""red\"";'>Your order was not submited</span>"";

            }
            });
    }


    function redirect(parm) {
        window.location.href = ""/UserHome/ProductDetail/"" + parm;
    }
</script>




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<ImanInfluencer.Models.Product1, IEnumerable<ImanInfluencer.Models.Product1>>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/UIElements/Notifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2b9e77ee865ea48c450a65fa4cc75f3cb676ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Main_Views_UIElements_Notifications), @"mvc.1.0.view", @"/Areas/Main/Views/UIElements/Notifications.cshtml")]
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
#line 1 "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/_ViewImports.cshtml"
using Labo2ASPdotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/_ViewImports.cshtml"
using Labo2ASPdotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2b9e77ee865ea48c450a65fa4cc75f3cb676ac", @"/Areas/Main/Views/UIElements/Notifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c49621e81a3ecffd90d67e0b913c6833184c42", @"/Areas/Main/Views/_ViewImports.cshtml")]
    public class Areas_Main_Views_UIElements_Notifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/Main/Views/Shared/NavigationBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/UIElements/Notifications.cshtml"
  
    ViewData["Title"] = "UI Elements Notifications Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a2b9e77ee865ea48c450a65fa4cc75f3cb676ac3706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">Notifications</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Alert Styles
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""alert alert-success"">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                    <div class=""alert alert-info"">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                    <div class=""alert alert-warning"">
                        Lorem ipsum dolor sit amet, consectetur ");
            WriteLiteral(@"adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                    <div class=""alert alert-danger"">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                </div>
                <!-- .panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Dismissable Alerts
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""alert alert-success alert-dismissable"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert");
            WriteLiteral(@" Link</a>.
                    </div>
                    <div class=""alert alert-info alert-dismissable"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                    <div class=""alert alert-warning alert-dismissable"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link"">Alert Link</a>.
                    </div>
                    <div class=""alert alert-danger alert-dismissable"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href=""#"" class=""alert-link");
            WriteLiteral(@""">Alert Link</a>.
                    </div>
                </div>
                <!-- .panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Modals
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <!-- Button trigger modal -->
                    <button class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#myModal"">
                        Launch Demo Modal
                    </button>
                    <!-- Modal -->
                    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                    ");
            WriteLiteral(@"            <div class=""modal-header"">
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                    <h4 class=""modal-title"" id=""myModalLabel"">Modal title</h4>
                                </div>
                                <div class=""modal-body"">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-default"" da");
            WriteLiteral(@"ta-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                </div>
                            </div>
                            <!-- /.modal-content -->
                        </div>
                        <!-- /.modal-dialog -->
                    </div>
                    <!-- /.modal -->
                </div>
                <!-- .panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Tooltips and Popovers
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <h4>Tooltip Demo</h4>
                    <div class=""tooltip-demo"">
                        <button type=""button"" class=""btn btn-default"" data-toggle=""tooltip"" data-placement=""");
            WriteLiteral(@"left"" title=""Tooltip on left"">Tooltip on left</button>
                        <button type=""button"" class=""btn btn-default"" data-toggle=""tooltip"" data-placement=""top"" title=""Tooltip on top"">Tooltip on top</button>
                        <button type=""button"" class=""btn btn-default"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Tooltip on bottom"">Tooltip on bottom</button>
                        <button type=""button"" class=""btn btn-default"" data-toggle=""tooltip"" data-placement=""right"" title=""Tooltip on right"">Tooltip on right</button>
                    </div>
                    <br>
                    <h4>Clickable Popover Demo</h4>
                    <div class=""tooltip-demo"">
                        <button type=""button"" class=""btn btn-default"" data-container=""body"" data-toggle=""popover"" data-placement=""left"" data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            Popover on left
                        </button>
                        <button typ");
            WriteLiteral(@"e=""button"" class=""btn btn-default"" data-container=""body"" data-toggle=""popover"" data-placement=""top"" data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            Popover on top
                        </button>
                        <button type=""button"" class=""btn btn-default"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom"" data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            Popover on bottom
                        </button>
                        <button type=""button"" class=""btn btn-default"" data-container=""body"" data-toggle=""popover"" data-placement=""right"" data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            Popover on right
                        </button>
                    </div>
                </div>
                <!-- .panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
    </div>
  ");
            WriteLiteral("  <!-- /.row -->\n</div>");
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

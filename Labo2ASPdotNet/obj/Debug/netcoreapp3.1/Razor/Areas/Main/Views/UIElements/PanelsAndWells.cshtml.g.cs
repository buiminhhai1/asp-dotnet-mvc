#pragma checksum "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/UIElements/PanelsAndWells.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd6b66a94068ffb4e92ca891f70264553138cb7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Main_Views_UIElements_PanelsAndWells), @"mvc.1.0.view", @"/Areas/Main/Views/UIElements/PanelsAndWells.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6b66a94068ffb4e92ca891f70264553138cb7b", @"/Areas/Main/Views/UIElements/PanelsAndWells.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c49621e81a3ecffd90d67e0b913c6833184c42", @"/Areas/Main/Views/_ViewImports.cshtml")]
    public class Areas_Main_Views_UIElements_PanelsAndWells : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Users/haibui/Projects/Labo2ASPdotNet/Labo2ASPdotNet/Areas/Main/Views/UIElements/PanelsAndWells.cshtml"
  
    ViewData["Title"] = "UI Elements Panels and Wells Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd6b66a94068ffb4e92ca891f70264553138cb7b3715", async() => {
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
            <h1 class=""page-header"">Panels and Wells</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Default Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    Primary Panel
                </div>
       ");
            WriteLiteral(@"         <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""panel panel-success"">
                <div class=""panel-heading"">
                    Success Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -");
            WriteLiteral(@"->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    Info Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""panel panel-warning"">
                <div class=""panel-heading"">
                    Warning Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus");
            WriteLiteral(@" adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""panel panel-danger"">
                <div class=""panel-heading"">
                    Danger Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
        </div>
        <!-- /.col-lg-4 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""panel panel-green"">
                <div class=""panel-heading"">
            ");
            WriteLiteral(@"        Green Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
            <!-- /.col-lg-4 -->
        </div>
        <div class=""col-lg-4"">
            <div class=""panel panel-yellow"">
                <div class=""panel-heading"">
                    Yellow Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
       ");
            WriteLiteral(@"     </div>
            <!-- /.col-lg-4 -->
        </div>
        <div class=""col-lg-4"">
            <div class=""panel panel-red"">
                <div class=""panel-heading"">
                    Red Panel
                </div>
                <div class=""panel-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                </div>
                <div class=""panel-footer"">
                    Panel Footer
                </div>
            </div>
            <!-- /.col-lg-4 -->
        </div>
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Collapsible Accordion Panel Group
                </div>
                <!-- .panel-heading -->
                <div class=""panel-body"">
                    <div class=");
            WriteLiteral(@"""panel-group"" id=""accordion"">
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"">Collapsible Group Item #1</a>
                                </h4>
                            </div>
                            <div id=""collapseOne"" class=""panel-collapse collapse in"">
                                <div class=""panel-body"">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id ");
            WriteLiteral(@"est laborum.
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"">Collapsible Group Item #2</a>
                                </h4>
                            </div>
                            <div id=""collapseTwo"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sin");
            WriteLiteral(@"t occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseThree"">Collapsible Group Item #3</a>
                                </h4>
                            </div>
                            <div id=""collapseThree"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in re");
            WriteLiteral(@"prehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- .panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Basic Tabs
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <!-- Nav tabs -->
                    <ul class=""nav nav-tabs"">
                        <li class=""active"">
                            <a href=""#home"" data-toggle=""tab"">Home</a>
                        </li>
               ");
            WriteLiteral(@"         <li>
                            <a href=""#profile"" data-toggle=""tab"">Profile</a>
                        </li>
                        <li>
                            <a href=""#messages"" data-toggle=""tab"">Messages</a>
                        </li>
                        <li>
                            <a href=""#settings"" data-toggle=""tab"">Settings</a>
                        </li>
                    </ul>

                    <!-- Tab panes -->
                    <div class=""tab-content"">
                        <div class=""tab-pane fade in active"" id=""home"">
                            <h4>Home Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupida");
            WriteLiteral(@"tat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""profile"">
                            <h4>Profile Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""messages"">
                            <h4>Messages Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim a");
            WriteLiteral(@"d minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""settings"">
                            <h4>Settings Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                    </div>
                </di");
            WriteLiteral(@"v>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
        <div class=""col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Pill Tabs
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <!-- Nav tabs -->
                    <ul class=""nav nav-pills"">
                        <li class=""active"">
                            <a href=""#home-pills"" data-toggle=""tab"">Home</a>
                        </li>
                        <li>
                            <a href=""#profile-pills"" data-toggle=""tab"">Profile</a>
                        </li>
                        <li>
                            <a href=""#messages-pills"" data-toggle=""tab"">Messages</a>
                        </li>
                        <li>
                            <a href=""#settings-pills"" data-toggle=""tab"">Settings</a>
");
            WriteLiteral(@"                        </li>
                    </ul>

                    <!-- Tab panes -->
                    <div class=""tab-content"">
                        <div class=""tab-pane fade in active"" id=""home-pills"">
                            <h4>Home Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""profile-pills"">
                            <h4>Profile Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ");
            WriteLiteral(@"labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                        <div class=""tab-pane fade"" id=""messages-pills"">
                            <h4>Messages Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
 ");
            WriteLiteral(@"                       <div class=""tab-pane fade"" id=""settings-pills"">
                            <h4>Settings Tab</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        </div>
                    </div>
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-6 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""well"">
                <h4>Normal Well</h4>
                <p>Lorem ipsum dolor sit amet, consectetur a");
            WriteLiteral(@"dipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""well well-lg"">
                <h4>Large Well</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
            </div>
        </div>
        <!-- /.col-lg-4 -->
        <div class=""col-lg-4"">
            <div class=""well well-sm"">
                <h4>Small Well</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
            </div>
        </div>
        <!-- /.col-lg-4 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-12"">
     ");
            WriteLiteral(@"       <div class=""jumbotron"">
                <h1>Jumbotron</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing.</p>
                <p>
                    <a class=""btn btn-primary btn-lg"" role=""button"">Learn more</a>
                </p>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
</div>");
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
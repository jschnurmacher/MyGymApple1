//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("MyGym.Views.Account.AccountWaiver.xaml", "Views/Account/AccountWaiver.xaml", typeof(global::MyGym.AccountWaiver))]

namespace MyGym {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views/Account/AccountWaiver.xaml")]
    public partial class AccountWaiver : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::MyGym.TitleBar titleBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.HtmlWebViewSource Waiver;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator activityIndicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AccountWaiver));
            titleBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::MyGym.TitleBar>(this, "titleBar");
            Waiver = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.HtmlWebViewSource>(this, "Waiver");
            activityIndicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "activityIndicator");
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("MyGym.Views.Account.AccountSocksBillingEdit.xaml", "Views/Account/AccountSocksBillingEdit.xaml", typeof(global::MyGym.AccountSocksBillingEdit))]

namespace MyGym {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views/Account/AccountSocksBillingEdit.xaml")]
    public partial class AccountSocksBillingEdit : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::MyGym.TitleBar titleBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout MainLayout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry CardName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry Email;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry Address;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry Apt;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry City;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadListPicker State;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry Zip;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry CCNum;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadListPicker CCExpMonth;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadListPicker CCExpYear;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry CCVN;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button submitButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button cancelButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator activityIndicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AccountSocksBillingEdit));
            titleBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::MyGym.TitleBar>(this, "titleBar");
            MainLayout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "MainLayout");
            CardName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "CardName");
            Email = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "Email");
            Address = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "Address");
            Apt = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "Apt");
            City = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "City");
            State = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadListPicker>(this, "State");
            Zip = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "Zip");
            CCNum = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "CCNum");
            CCExpMonth = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadListPicker>(this, "CCExpMonth");
            CCExpYear = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadListPicker>(this, "CCExpYear");
            CCVN = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "CCVN");
            submitButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "submitButton");
            cancelButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "cancelButton");
            activityIndicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "activityIndicator");
        }
    }
}

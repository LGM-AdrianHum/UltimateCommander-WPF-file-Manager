﻿#pragma checksum "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9EB20D99EAC7CBAB4F70CB4570D71C39357E8A2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace JoyOs.Windows.Dialogs.Files {
    
    
    /// <summary>
    /// ChangeAttributes
    /// </summary>
    public partial class ChangeAttributes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox archive;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox readOnly;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox hidden;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox system;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox folderFile;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/JoyOs.Windows;component/dialogs/files/changeattributes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.archive = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.readOnly = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.hidden = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.system = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.folderFile = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Dialogs\Files\ChangeAttributes.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.OkButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

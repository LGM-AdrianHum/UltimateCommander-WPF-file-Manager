﻿#pragma checksum "..\..\MediaViewer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960A4C1096B7D491652EFB0AA76430145079BF36"
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


namespace UcMediaViewer {
    
    
    /// <summary>
    /// MediaViewer
    /// </summary>
    public partial class MediaViewer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainDockPanel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Menu mainMenu;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListViewer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer wrapList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MediaViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel imgWrapList;
        
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
            System.Uri resourceLocater = new System.Uri("/UcMediaViewer;component/mediaviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MediaViewer.xaml"
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
            this.mainDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.mainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            
            #line 20 "..\..\MediaViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenMediaPluginClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\MediaViewer.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButtonChecked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MediaViewer.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.RadioButtonChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\MediaViewer.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButtonChecked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MediaViewer.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.RadioButtonChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListViewer = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.list = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.wrapList = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 9:
            this.imgWrapList = ((System.Windows.Controls.WrapPanel)(target));
            
            #line 29 "..\..\MediaViewer.xaml"
            this.imgWrapList.SizeChanged += new System.Windows.SizeChangedEventHandler(this.PanelSizeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


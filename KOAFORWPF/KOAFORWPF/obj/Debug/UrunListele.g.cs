﻿#pragma checksum "..\..\UrunListele.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5FE09D3E69DB815FBDEFDA70A45D7D13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace KOAFORWPF {
    
    
    /// <summary>
    /// UrunListele
    /// </summary>
    public partial class UrunListele : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\UrunListele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TabloGrid;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\UrunListele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YenileButton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\UrunListele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cikisButton;
        
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
            System.Uri resourceLocater = new System.Uri("/KOAFORWPF;component/urunlistele.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UrunListele.xaml"
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
            
            #line 4 "..\..\UrunListele.xaml"
            ((KOAFORWPF.UrunListele)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TabloGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.YenileButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\UrunListele.xaml"
            this.YenileButton.Click += new System.Windows.RoutedEventHandler(this.YenileButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cikisButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\UrunListele.xaml"
            this.cikisButton.Click += new System.Windows.RoutedEventHandler(this.cikisButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Windows\AddLoginWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1AE1D29F57E15F2AC2F1F1011BE90CB0DFB8F30DC2959A33BD7CADD96EC7C4D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1.Windows;


namespace WpfApp1.Windows {
    
    
    /// <summary>
    /// AddLoginWindow
    /// </summary>
    public partial class AddLoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridLogin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox teacherNameBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filterTextBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid loginsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Windows\AddLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock countTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windows/addloginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddLoginWindow.xaml"
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
            
            #line 12 "..\..\..\Windows\AddLoginWindow.xaml"
            ((WpfApp1.Windows.AddLoginWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Roate);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Windows\AddLoginWindow.xaml"
            ((WpfApp1.Windows.AddLoginWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridLogin = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 4:
            
            #line 29 "..\..\..\Windows\AddLoginWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.teacherNameBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.loginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.passwordBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 79 "..\..\..\Windows\AddLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 84 "..\..\..\Windows\AddLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 99 "..\..\..\Windows\AddLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.filterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\..\Windows\AddLoginWindow.xaml"
            this.filterTextBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.filterTextBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.loginsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            
            #line 176 "..\..\..\Windows\AddLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.countTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


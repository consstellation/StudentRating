﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07D99E13A534F86C9B104C11FEA470D60520DCFEEA7638A966462BDCD6311958"
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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox subjectBox;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeLessonBox;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker lessonDateBox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox useDate;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pointAndHoursBox;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid clientsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            
            #line 10 "..\..\..\Pages\MainPage.xaml"
            ((WpfApp1.Pages.MainPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.groupBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\Pages\MainPage.xaml"
            this.groupBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.groupBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.subjectBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\Pages\MainPage.xaml"
            this.subjectBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.subjectBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.typeLessonBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\Pages\MainPage.xaml"
            this.typeLessonBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.typeLessonBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lessonDateBox = ((System.Windows.Controls.DatePicker)(target));
            
            #line 111 "..\..\..\Pages\MainPage.xaml"
            this.lessonDateBox.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.lessonDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.useDate = ((System.Windows.Controls.CheckBox)(target));
            
            #line 114 "..\..\..\Pages\MainPage.xaml"
            this.useDate.Click += new System.Windows.RoutedEventHandler(this.useDate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pointAndHoursBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 140 "..\..\..\Pages\MainPage.xaml"
            this.pointAndHoursBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pointBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 154 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 162 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddLesson_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 171 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditLesson_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\..\Pages\MainPage.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteLesson_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.clientsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

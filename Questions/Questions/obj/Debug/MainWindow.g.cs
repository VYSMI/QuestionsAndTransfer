﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10A93E496FB55CBF606712E22E2ACFB99E3B57557FA430162E474E8789BBD3B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Questions;
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


namespace Questions {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid endGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCl;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mark;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridStart;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClo;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid QuestionsGrid;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClo2;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreText;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image questionImage;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans1;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans2;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans3;
        
        #line default
        #line hidden
        
        
        #line 376 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans4;
        
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
            System.Uri resourceLocater = new System.Uri("/Questions;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 16 "..\..\MainWindow.xaml"
            ((Questions.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.windowMoused);
            
            #line default
            #line hidden
            return;
            case 2:
            this.endGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.endGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EndMoused);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCl = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.btnCl.Click += new System.Windows.RoutedEventHandler(this.btnClose2_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mark = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.gridStart = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.btnClo = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\MainWindow.xaml"
            this.btnClo.Click += new System.Windows.RoutedEventHandler(this.btnClose2_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.QuestionsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.btnClo2 = ((System.Windows.Controls.Button)(target));
            
            #line 229 "..\..\MainWindow.xaml"
            this.btnClo2.Click += new System.Windows.RoutedEventHandler(this.btnClose2_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.scoreText = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.questionImage = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.ans1 = ((System.Windows.Controls.Button)(target));
            
            #line 282 "..\..\MainWindow.xaml"
            this.ans1.Click += new System.Windows.RoutedEventHandler(this.chkAnswer);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ans2 = ((System.Windows.Controls.Button)(target));
            
            #line 307 "..\..\MainWindow.xaml"
            this.ans2.Click += new System.Windows.RoutedEventHandler(this.chkAnswer);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ans3 = ((System.Windows.Controls.Button)(target));
            
            #line 341 "..\..\MainWindow.xaml"
            this.ans3.Click += new System.Windows.RoutedEventHandler(this.chkAnswer);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ans4 = ((System.Windows.Controls.Button)(target));
            
            #line 375 "..\..\MainWindow.xaml"
            this.ans4.Click += new System.Windows.RoutedEventHandler(this.chkAnswer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\savepanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C06E87461AF2A54117E9DC29D01CC25ABE2D77E04E7CDC7299CA4F85F08364CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SaveMerge;
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


namespace SaveMerge {
    
    
    /// <summary>
    /// SavePanel
    /// </summary>
    public partial class SavePanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbxSave;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPath;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSteamID;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSteamID;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel splSlots;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\savepanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/SaveMerge;component/savepanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\savepanel.xaml"
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
            
            #line 2 "..\..\savepanel.xaml"
            ((SaveMerge.SavePanel)(target)).DragEnter += new System.Windows.DragEventHandler(this.UserControl_DragEnter);
            
            #line default
            #line hidden
            
            #line 2 "..\..\savepanel.xaml"
            ((SaveMerge.SavePanel)(target)).Drop += new System.Windows.DragEventHandler(this.UserControl_Drop);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gbxSave = ((System.Windows.Controls.GroupBox)(target));
            
            #line 3 "..\..\savepanel.xaml"
            this.gbxSave.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.GbxSave_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lblSteamID = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtSteamID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.splSlots = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\savepanel.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


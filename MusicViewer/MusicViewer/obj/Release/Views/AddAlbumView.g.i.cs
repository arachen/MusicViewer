﻿#pragma checksum "..\..\..\Views\AddAlbumView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "87BF6AF8DE25C006AE4F5BADFE4F494D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MusicViewer.ViewModels;
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


namespace MusicViewer.Views {
    
    
    /// <summary>
    /// AddAlbumView
    /// </summary>
    public partial class AddAlbumView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddAlbumGrid;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox albumNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox artistNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageGrid;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image addAlbumCoverImage;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox showCoverPath;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAlbumCoverBrowseBtn;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearAlbumCoverBtn;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\AddAlbumView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAlbumBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MusicViewer;component/views/addalbumview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddAlbumView.xaml"
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
            this.AddAlbumGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.albumNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.artistNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.imageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.addAlbumCoverImage = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.showCoverPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.addAlbumCoverBrowseBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.clearAlbumCoverBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.addAlbumBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


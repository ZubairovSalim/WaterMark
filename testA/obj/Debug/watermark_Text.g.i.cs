﻿#pragma checksum "..\..\watermark_Text.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9852B05ECB4E037791D3D293AF520FB4"
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
using testA;


namespace testA {
    
    
    /// <summary>
    /// watermark_Text
    /// </summary>
    public partial class watermark_Text : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddImage;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Impose;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_Image;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Watermark;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_Result;
        
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
            System.Uri resourceLocater = new System.Uri("/testA;component/watermark_text.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\watermark_Text.xaml"
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
            this.btn_AddImage = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\watermark_Text.xaml"
            this.btn_AddImage.Click += new System.Windows.RoutedEventHandler(this.btn_AddImage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Impose = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\watermark_Text.xaml"
            this.btn_Impose.Click += new System.Windows.RoutedEventHandler(this.btn_Impose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.img_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.txb_Watermark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.img_Result = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

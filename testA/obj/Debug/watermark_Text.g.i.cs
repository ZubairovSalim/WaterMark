﻿#pragma checksum "..\..\watermark_Text.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48C6A6E9274E9E4F4B22AB4412B42143"
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
        
        
        #line 11 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddImage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_Image;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Opacity;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Name;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Size;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CurrentColor;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Impose;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\watermark_Text.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Watermark;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\watermark_Text.xaml"
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
            
            #line 11 "..\..\watermark_Text.xaml"
            this.btn_AddImage.Click += new System.Windows.RoutedEventHandler(this.btn_AddImage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.img_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.txb_Opacity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txb_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txb_Size = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_CurrentColor = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            
            #line 31 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 33 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 34 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 35 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 36 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 39 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 40 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 41 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 42 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 43 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 44 "..\..\watermark_Text.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Color_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btn_Impose = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\watermark_Text.xaml"
            this.btn_Impose.Click += new System.Windows.RoutedEventHandler(this.btn_Impose_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\watermark_Text.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.txb_Watermark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.img_Result = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


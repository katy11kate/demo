﻿#pragma checksum "..\..\..\..\Windows\Card.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23D2A9BEC8408FC98CBDB83C9BA0C298297464E8"
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
using System.Windows.Controls.Ribbon;
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
using ООО_Техносервис.Windows;


namespace ООО_Техносервис.Windows {
    
    
    /// <summary>
    /// Card
    /// </summary>
    public partial class Card : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox device;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox opisanie;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox type;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox client;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox employeecomb;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button done;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\Card.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView List;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ООО Техносервис;component/windows/card.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Card.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Windows\Card.xaml"
            ((ООО_Техносервис.Windows.Card)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.device = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.opisanie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.client = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.employeecomb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Windows\Card.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.done = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Windows\Card.xaml"
            this.done.Click += new System.Windows.RoutedEventHandler(this.done_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Windows\Card.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.List = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            
            #line 52 "..\..\..\..\Windows\Card.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


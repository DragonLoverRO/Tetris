﻿#pragma checksum "C:\Users\andra\Documents\GitHub\Tetris\UWP_Tetris\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F8BFDD56FAF3C4957D0F543498423E50"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_Tetris
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.canvas = (global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl)(target);
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl)this.canvas).Draw += this.Canvas_Draw;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl)this.canvas).Update += this.Canvas_Update;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl)this.canvas).CreateResources += this.Canvas_CreateResources;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeStrikes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Res {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Res() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThreeStrikes.Res", typeof(Res).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In the game&apos;s current standard format, the contestant is shown eight chips, five of which have a unique digit representing one of the five numbers in the price of the car, and three red chips that each have an X, called a strike. The chips are placed into a bag and shuffled.
        ///
        ///The contestant blindly draws a chip from the bag. If they pick a number, they must decide in which position (spot) that digit belongs (e.g.: &quot;the third digit&quot;). If they are correct, the chip is discarded into a slot in the game board [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Instructions {
            get {
                return ResourceManager.GetString("Instructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt; 
        ///&lt;Prizes&gt;
        ///  &lt;Prize&gt;
        ///    &lt;Name&gt;2014 Mazda 6&lt;/Name&gt;  
        ///    &lt;Value&gt;29675&lt;/Value&gt;
        ///  &lt;/Prize&gt;
        ///  &lt;Prize&gt;
        ///    &lt;Name&gt;All Inclusive Hawaiian Vacation&lt;/Name&gt;  
        ///    &lt;Value&gt;10432&lt;/Value&gt;
        ///  &lt;/Prize&gt;
        ///  &lt;Prize&gt;
        ///    &lt;Name&gt;Fleetwood RV&lt;/Name&gt;
        ///    &lt;Value&gt;65015&lt;/Value&gt;
        ///  &lt;/Prize&gt;
        ///&lt;/Prizes&gt;.
        /// </summary>
        public static string Prizes {
            get {
                return ResourceManager.GetString("Prizes", resourceCulture);
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_1_asp_net.Resources {
    using lab_1_asp_net.Resources;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CreateOrder
    {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CreateOrder() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("lab_1_asp_net.Resources.CreateOrder", typeof(Texts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        public static string Name
        {
            get
            {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }
        public static string ProductName
        {
            get
            {
                return ResourceManager.GetString("ProductName", resourceCulture);
            }
        }
        public static string TotalPrice
        {
            get
            {
                return ResourceManager.GetString("TotalPrice", resourceCulture);
            }
        }
        public static string UserId
        {
            get
            {
                return ResourceManager.GetString("UserId", resourceCulture);
            }
        }
    }
}

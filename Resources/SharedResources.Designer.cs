﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_1_asp_net.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SharedResources
    {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SharedResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("lab_1_asp_net.Resources.SharedResources", typeof(Texts).Assembly);
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
        public static string Email
        {
            get
            {
                return ResourceManager.GetString("Email", resourceCulture);
            }
        }
        public static string PhoneNumber
        {
            get
            {
                return ResourceManager.GetString("PhoneNumber", resourceCulture);
            }
        }
        public static string Address
        {
            get
            {
                return ResourceManager.GetString("Address", resourceCulture);
            }
        }
        public static string FullName
        {
            get
            {
                return ResourceManager.GetString("FullName", resourceCulture);
            }
        }
        public static string Price
        {
            get
            {
                return ResourceManager.GetString("Price", resourceCulture);
            }
        }
        public static string Name
        {
            get
            {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }


    }
}

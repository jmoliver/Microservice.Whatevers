﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microservice.Whatevers.Domain {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DomainResource {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DomainResource() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Microservice.Whatevers.Domain.DomainResource", typeof(DomainResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string Identifier_invalid {
            get {
                return ResourceManager.GetString("Identifier_invalid", resourceCulture);
            }
        }
        
        internal static string Thing_Name_invalid {
            get {
                return ResourceManager.GetString("Thing_Name_invalid", resourceCulture);
            }
        }
        
        internal static string Thing_Type_invalid {
            get {
                return ResourceManager.GetString("Thing_Type_invalid", resourceCulture);
            }
        }
        
        internal static string Thing_Value_less_than_zero {
            get {
                return ResourceManager.GetString("Thing_Value_less_than_zero", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GemsCLITests.Properties {
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
    public class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GemsCLITests.Properties.Errors", typeof(Errors).Assembly);
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
        ///   Looks up a localized string similar to Empty or Null name value not allowed..
        /// </summary>
        public static string ArgumentNullName {
            get {
                return ResourceManager.GetString("ArgumentNullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty pattern..
        /// </summary>
        public static string DescriptionFactoryNoPattern {
            get {
                return ResourceManager.GetString("DescriptionFactoryNoPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must have help..
        /// </summary>
        public static string DescriptionHelp {
            get {
                return ResourceManager.GetString("DescriptionHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name must start with letter, and contain alphanumeric only..
        /// </summary>
        public static string DescriptionInvalidName {
            get {
                return ResourceManager.GetString("DescriptionInvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must have a name..
        /// </summary>
        public static string DescriptionName {
            get {
                return ResourceManager.GetString("DescriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Named parameters without values can not be multiple..
        /// </summary>
        public static string DescriptionSingle {
            get {
                return ResourceManager.GetString("DescriptionSingle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passed parameters must have a type..
        /// </summary>
        public static string DescriptionTypeRequired {
            get {
                return ResourceManager.GetString("DescriptionTypeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help not defined for {0}.
        /// </summary>
        public static string HelpNotFound {
            get {
                return ResourceManager.GetString("HelpNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter type can not be empty..
        /// </summary>
        public static string ParamTypeFactoryNull {
            get {
                return ResourceManager.GetString("ParamTypeFactoryNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter type {0} is not supported..
        /// </summary>
        public static string ParamTypeFactoryUnknown {
            get {
                return ResourceManager.GetString("ParamTypeFactoryUnknown", resourceCulture);
            }
        }
    }
}

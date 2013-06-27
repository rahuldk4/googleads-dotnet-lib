﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Api.Ads.AdWords {
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
    internal class AdWordsErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AdWordsErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Google.Api.Ads.AdWords.AdWordsErrorMessages", typeof(AdWordsErrorMessages).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An API exception has occurred. See ApiException and InnerException fields for more details..
        /// </summary>
        internal static string AnApiExceptionOccurred {
            get {
                return ResourceManager.GetString("AnApiExceptionOccurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AdWords API can find out effective user from the authorization headers, but setting a client customer ID explicitly is recommended. If the credentials in your configuration corresponds to an MCC account, you may not see any data..
        /// </summary>
        internal static string ClientCustomerIdIsEmpty {
            get {
                return ResourceManager.GetString("ClientCustomerIdIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AdWords API requires a developer token. If you don&apos;t have one, you can refer to the instructions at https://developers.google.com/adwords/api/docs/signingup to get one..
        /// </summary>
        internal static string DeveloperTokenCannotBeEmpty {
            get {
                return ResourceManager.GetString("DeveloperTokenCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not set AuthToken for outgoing API call. Please check if service.RequestHeader is not null..
        /// </summary>
        internal static string FailedToSetAuthorizationHeader {
            get {
                return ResourceManager.GetString("FailedToSetAuthorizationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid stage for Soap message..
        /// </summary>
        internal static string InvalidStageForSoapMessage {
            get {
                return ResourceManager.GetString("InvalidStageForSoapMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OAuth provider cannot be null when selecting Authorization method as &quot;OAuth&quot;..
        /// </summary>
        internal static string OAuthProviderCannotBeNull {
            get {
                return ResourceManager.GetString("OAuthProviderCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Report generation failed..
        /// </summary>
        internal static string ReportGenerationFailed {
            get {
                return ResourceManager.GetString("ReportGenerationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Report contents are invalid..
        /// </summary>
        internal static string ReportIsInvalid {
            get {
                return ResourceManager.GetString("ReportIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Report could not be downloaded after {0} polling attempts. Try requesting a report with lesser amount of data, increase the number of polling attempts, or use the asynchronous download methods..
        /// </summary>
        internal static string ReportNumPollsExceeded {
            get {
                return ResourceManager.GetString("ReportNumPollsExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature should be a {0} instance..
        /// </summary>
        internal static string SignatureIsOfWrongType {
            get {
                return ResourceManager.GetString("SignatureIsOfWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error occurred while converting v13 SoapException. See innerException for the original SoapException..
        /// </summary>
        internal static string Unknownv13SoapExceptionOccurred {
            get {
                return ResourceManager.GetString("Unknownv13SoapExceptionOccurred", resourceCulture);
            }
        }
    }
}

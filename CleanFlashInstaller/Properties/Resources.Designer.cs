﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanFlashInstaller.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CleanFlashInstaller.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap flashLogo {
            get {
                object obj = ResourceManager.GetObject("flashLogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Control Panel\Extended Properties\System.ControlPanel.Category]
        ///&quot;${SYSTEM_32_PATH}\\FlashPlayerCPLApp.cpl&quot;=dword:0000000a
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FlashPlayerApp.exe]
        ///&quot;DisableExceptionChainValidation&quot;=dword:00000000
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Uninstall\Clean Flash Player]
        ///&quot;DisplayName&quot;=&quot;Clean Flash Player ${VERSION}&quot;
        ///&quot;HelpLink&quot;=&quot;https [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string installGeneral {
            get {
                return ResourceManager.GetString("installGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Control Panel\Extended Properties\System.ControlPanel.Category]
        ///&quot;${SYSTEM_32_PATH}\\FlashPlayerCPLApp.cpl&quot;=dword:0000000a
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FlashPlayerApp.exe]
        ///&quot;DisableExceptionChainValidation&quot;=dword:00000000.
        /// </summary>
        internal static string installGeneral64 {
            get {
                return ResourceManager.GetString("installGeneral64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Macromedia\FlashPlayerPlugin]
        ///&quot;isPartner&quot;=dword:00000001
        ///&quot;Version&quot;=&quot;${VERSION}&quot;
        ///&quot;PlayerPath&quot;=&quot;${FLASH_64_PATH}\\NPSWF${ARCH}_${VERSION_PATH}.dll&quot;
        ///&quot;UninstallerPath&quot;=-
        ///&quot;isScriptDebugger&quot;=dword:00000000
        ///&quot;isESR&quot;=dword:00000000
        ///&quot;isMSI&quot;=dword:00000000
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Macromedia\FlashPlayerPluginReleaseType]
        ///&quot;Release&quot;=dword:00000001
        ///
        ///[HKEY_LOCAL_MACHINE\Software\MozillaPlugins\@adobe.com/FlashPlayer]
        ///&quot;Vendor&quot;=&quot;Adobe&quot;
        ///&quot;ProductName&quot;=&quot;Adobe® Flash® Player ${VER [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string installNP {
            get {
                return ResourceManager.GetString("installNP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Wow6432Node\Macromedia\FlashPlayerPlugin]
        ///&quot;PlayerPath&quot;=&quot;${FLASH_32_PATH}\\NPSWF_${VERSION_PATH}.dll&quot;
        ///&quot;Version&quot;=&quot;${VERSION}&quot;
        ///&quot;UninstallerPath&quot;=-
        ///&quot;isScriptDebugger&quot;=dword:00000000
        ///&quot;isESR&quot;=dword:00000000
        ///&quot;isMSI&quot;=dword:00000000
        ///&quot;isPartner&quot;=dword:00000001
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Wow6432Node\Macromedia\FlashPlayerPluginReleaseType]
        ///&quot;Release&quot;=dword:00000001
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Wow6432Node\MozillaPlugins\@adobe.com/FlashPlayer]
        ///&quot;ProductName&quot;=&quot;Adobe® Flash® P [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string installNP64 {
            get {
                return ResourceManager.GetString("installNP64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Macromedia\FlashPlayerPepper]
        ///&quot;UninstallerPath&quot;=-
        ///&quot;PlayerPath&quot;=&quot;${FLASH_64_PATH}\\pepflashplayer${ARCH}_${VERSION_PATH}.dll&quot;
        ///&quot;isScriptDebugger&quot;=dword:00000000
        ///&quot;isESR&quot;=dword:00000000
        ///&quot;isMSI&quot;=dword:00000000
        ///&quot;isPartner&quot;=dword:00000001
        ///&quot;Version&quot;=&quot;${VERSION}&quot;
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Macromedia\FlashPlayerPepperReleaseType]
        ///&quot;Release&quot;=dword:00000001.
        /// </summary>
        internal static string installPP {
            get {
                return ResourceManager.GetString("installPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [HKEY_LOCAL_MACHINE\Software\Wow6432Node\Macromedia\FlashPlayerPepper]
        ///&quot;UninstallerPath&quot;=-
        ///&quot;PlayerPath&quot;=&quot;${FLASH_32_PATH}\\pepflashplayer32_${VERSION_PATH}.dll&quot;
        ///&quot;isScriptDebugger&quot;=dword:00000000
        ///&quot;isESR&quot;=dword:00000000
        ///&quot;isMSI&quot;=dword:00000000
        ///&quot;isPartner&quot;=dword:00000001
        ///&quot;Version&quot;=&quot;${VERSION}&quot;
        ///
        ///[HKEY_LOCAL_MACHINE\Software\Wow6432Node\Macromedia\FlashPlayerPepperReleaseType]
        ///&quot;Release&quot;=dword:00000001.
        /// </summary>
        internal static string installPP64 {
            get {
                return ResourceManager.GetString("installPP64", resourceCulture);
            }
        }
    }
}
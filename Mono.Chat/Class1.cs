using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mono.Chat
{
    public class InternetExplorer
    {
        private readonly Type? ieType;
        public bool IsInstalled
        {
            get
            {
                return ieType != null;
            }
        }

        public InternetExplorer()
        {
            ieType = Type.GetTypeFromProgID("InternetExplorer.Application");
        }

        public void Open(string url = "https://msnld.com/legacy/")
        {
            if (ieType == null)
            {
                MessageBox.Show("Internet Explorer is not installed on this computer.", "Unable to open Internet Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create IE instance
                object? IE = System.Activator.CreateInstance(ieType);
                if (IE != null)
                {
                    // Navigate to our URL
                    IE.GetType().InvokeMember("Navigate", System.Reflection.BindingFlags.InvokeMethod, null, IE, [url]);
                    // Show IE window
                    IE.GetType().InvokeMember("Visible", System.Reflection.BindingFlags.SetProperty, null, IE, [true]);
                    // We can safely release the COM object without the browser closing
                    Marshal.ReleaseComObject(IE);
                    // Remove reference for GC
                    IE = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to create Internet Explorer instance");
            }
        }
    }
}

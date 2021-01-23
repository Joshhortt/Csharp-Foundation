using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    { 
        private void Demo()  // 1b. 
        {
            PrivateDemo();
        }
        
       
        private void PrivateDemo()  // 1. It's only accessible inside the area where it is declared
        {
            
        }

        private protected void PrivateProtectedDemo()
        {

        }

        protected void ProtectedDemo()
        {

        }

        protected internal void ProtectedInternalDemo()
        {

        }

        internal void InternalDemo()
        {

        }

        public void PublicDemo()
        {
            PrivateDemo();
            // Demo.  4. Private appear, so From here you can call PrivateDemo
            //       Note:  That means you can call Private only between the class Access Demo curly braces area
        }
    }
}

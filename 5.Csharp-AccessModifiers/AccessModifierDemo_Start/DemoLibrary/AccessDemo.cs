using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        //#################### private #############################
        private void Demo()  
        {
            PrivateDemo();
        }
        
        private void PrivateDemo()  
        {
            
        }
        //#################### private #############################



        //############### private protected ########################
        private protected void PrivateProtectedDemo()   
        {

        }
        //############### private protected ########################



        //##################### protected ##########################
        protected void ProtectedDemo()  
        {                               

        }
        //##################### protected ##########################



        //################# protected internal #####################
        protected internal void ProtectedInternalDemo()   // 1. Protected internal is protected inside it's own assembly 'Demo Library' &
                                                             // inheritanceDemo class.
        {

        }
        //################# protected internal #####################

        // 3.Private Protected can be called from here
        //PublicDemo();

        //##################### internal ###########################
        internal void InternalDemo()  
        {                                                      

        }
        //##################### internal ###########################



        //###################### public ############################
        public void PublicDemo()
        { 
        
        }  
        //###################### public ############################
    }
}

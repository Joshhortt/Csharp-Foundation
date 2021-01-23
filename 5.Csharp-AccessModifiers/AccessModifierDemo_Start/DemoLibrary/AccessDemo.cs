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
        protected void ProtectedDemo()  // 1. Used very much with Inheritance
        {                               // Note: Good to use to protect any outside acces from the inherited class you re working on for example

        }
        //##################### protected ##########################



        //################# protected internal #####################
        protected internal void ProtectedInternalDemo()
        {

        }
        //################# protected internal #####################



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

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
        private protected void PrivateProtectedDemo()   // 1. Available in AccessDemo
        {

        }
        //############### private protected ########################



        //##################### protected ##########################
        protected void ProtectedDemo()  
        {                               

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

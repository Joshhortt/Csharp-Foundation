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
        public void PublicDemo()  // 1. Accessible everywhere
        {                        // Note: From any Assembly it is accessible
           
        }
        //###################### public ############################
    }
}

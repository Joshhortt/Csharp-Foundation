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
        internal void InternalDemo()  // 1. Broader in scope but kind of like private. Example i this case it's inside the same DemoLibrary
        {                             // Note. Internal works inside the same assembly, never out of the same assembly.                          

        }
        //##################### internal ###########################



        //###################### public ############################
        public void PublicDemo()
        {
           
        }
        //###################### public ############################
    }
}

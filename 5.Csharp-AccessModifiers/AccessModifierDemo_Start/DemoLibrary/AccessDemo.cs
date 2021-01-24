using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        //############## 6 DIFFERENT TYPES OF MODIFIERS #################

        //#################### private #############################
        private void PrivateDemo()  
        {
            // 2. LEAST ACCESSIBLE. WHICH IS INSIDE THE SAME CLASS
        }
        //#################### private #############################



        //############### private protected ########################
        private protected void PrivateProtectedDemo()   
        {
            // 6. IT IS ONLY AVAILABLE INSIDE THE CLASS THAT DECLARED IT AS WELL AS THE CLASSE INHERITS FROM IT, BUT ONLY IN THE SAME ASSEMBLY
        }
        //############### private protected ########################



        //##################### protected ##########################
        protected void ProtectedDemo()  
        {                               
            // 3.INSIDE THE CLASS WHER IT WAS CREATED IN OR INSIDE WHERE IT DERIVES FROM THAT CLASS
        }
        //##################### protected ##########################



        //################# protected internal #####################
        protected internal void ProtectedInternalDemo()  
        {
            // 5. WORKS INSIDE OF THE SAME ASSEMBLY AND WHERE IT INHERITS FROM IN THIS CASE FROM 
        }
        //################# protected internal #####################

       

        //##################### internal ###########################
        internal void InternalDemo()  
        {                                                      
            // 4. WORKS ANYWHERE INSIDE THE SAME ASSEMBLY
        }
        //##################### internal ###########################



        //###################### public ############################
        public void PublicDemo()
        { 
          // 1. ACCESSIBLE FROM EVERYWHERE
        }  
        //###################### public ############################
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNG_BusinessLogic
{
    public static class cls_SequenceGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"> Pssitive number</param>
        /// <returns> string sequence  of all numbers in range up to input</returns>
        public static string getAllSequence( int input)
        {
            string strSequence = "0";
            try {
               for(int i=1; i<=input;i++)
                {
                    strSequence = strSequence+", "+ i;
                }
            }
            catch (Exception ex)
            {
                // log exception
                throw ex;// catch in upper level 
            }
            finally
            {
                // write must run code here.
            }
            return strSequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"> Pssitive number</param>
        /// <returns> string sequence of all Odd numbers in range up to input</returns>
        public static string getOddSequence(int input)
        {
            string strSequence=string.Empty;
            try
            {
                for (int i = 0; i <= input; i++)
                {
                    if(i % 2 != 0)
                    {
                        if(strSequence == string.Empty) { strSequence = i.ToString(); }
                        else { strSequence = strSequence+", "+i.ToString(); }
                    }
                    else { if (i == input) { strSequence = strSequence + ", " + i.ToString(); } }
                }
            }
            catch (Exception ex)
            {
                // log exception
                throw ex;// catch in upper level 
            }
            finally
            {
                // write must run code here.
            }
            return strSequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"> Pssitive number</param>
        /// <returns> String of all Even numbers in range up to input</returns>
        public static string getEvenSequence(long input)
        {
            string strSequence = string.Empty;
            try
            {
                for (int i = 0; i <= input; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (strSequence == string.Empty) { strSequence = i.ToString(); }
                        else { strSequence = strSequence + ", " + i.ToString(); }
                    }
                    else { if (i == input) { strSequence = strSequence + ", " + i.ToString(); } }
                }
            }
            catch (Exception ex)
            {
                // log exception
                throw ex;// catch in upper level 
            }
            finally
            {
                // write must run code here.
            }
            return strSequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"> Pssitive number</param>
        /// <returns> string sequence of all numbers in range up to input and multiple of 3,5 or both</returns>
        public static string getAllLogicSequence(int input)
        {
            string strSequence ="0";
            try
            {
                for (int i = 1; i <= input; i++)
                {
                    if((i % 3) ==0 && (i % 5) != 0) { strSequence= strSequence+", C"; }
                    else if ((i % 5) == 0 && (i % 3) != 0) { strSequence = strSequence + ", E"; }
                    else if ((i % 3) == 0 && (i % 5) == 0) { strSequence = strSequence + ", Z"; }
                    else { strSequence = strSequence + ", " + i.ToString(); }
                    
                }
            }
            catch (Exception ex)
            {
                // log exception
                throw ex;// catch in upper level 
            }
            finally
            {
                // write must run code here.
            }
            return strSequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"> Pssitive number</param>
        /// <returns> array of all numbers in range up to input and multiple of 3,5 or both</returns>
        public static string getFibonacciSequence(int input)
        {
           string strSequence="0,1";
            try
            {
              
                int a = 0, b = 1, c = 0;

                for (int i = 2; i < input; i++)
                {
                    c = a + b;
                    if (c <= input)
                    {
                        strSequence = strSequence + ", " + c.ToString();
                        a = b;
                        b = c;
                    }
                    else
                    {
                        if(c != input && i < input) { strSequence = strSequence + ", "+input.ToString(); }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                // log exception
                throw ex;// catch in upper level 
            }
            finally
            {
                // write must run code here.
            }
            return strSequence;
        }
    }
}

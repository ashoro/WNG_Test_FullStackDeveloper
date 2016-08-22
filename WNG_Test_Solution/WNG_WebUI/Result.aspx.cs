using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WNG_BusinessLogic;

namespace WNG_WebUI
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Request.QueryString.Count > 0)
                {
                    string strNumberEntered = Request.QueryString[0].ToString();
                   if(strNumberEntered.Length > 0)
                    {
                        lblNumber.Text =strNumberEntered;
                        loadResult(Convert.ToInt32(strNumberEntered));
                    }

                }

            }catch(Exception ex)
            {

            }
        }

        private void loadResult(int input)
        {

            lblResult1.Text = cls_SequenceGenerator.getAllSequence(input);
            lblResult2.Text = cls_SequenceGenerator.getOddSequence(input);
            lblResult3.Text = cls_SequenceGenerator.getEvenSequence(input);
            lblResult4.Text = cls_SequenceGenerator.getAllLogicSequence(input);
            lblResult5.Text = cls_SequenceGenerator.getFibonacciSequence(input);
        }

        protected void btnStartOver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
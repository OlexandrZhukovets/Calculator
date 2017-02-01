using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        string operation = "null";
        double value = 0.0;
        
        bool clickOperation = false;
        
        enum ViewStateConsts
        {
            text,
            operation,
            value,
            clickOperation
        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        // Кнопки-цифрЫ
        protected void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (ViewState[ViewStateConsts.clickOperation.ToString()] != null)
            {
            clickOperation = true;
            }
            
            if ((result.Text == "0") || (clickOperation))
            {
                result.Text = "";
           }          
            
            if (ViewState[ViewStateConsts.text.ToString()] != null)
            {
                result.Text = (string)ViewState[ViewStateConsts.text.ToString()];
            }
            int count = 0;
            foreach (Match m in Regex.Matches(result.Text, ","))
                count++;
            if (count >=1)
            {

            }
            else { result.Text += b.Text; }
            ViewState[ViewStateConsts.text.ToString()] = (object)result.Text;
           
        }
        //Кнопки-операторы "+"и т.д.
        protected void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = ViewState[ViewStateConsts.text.ToString()].ToString();
            
            if (ViewState[ViewStateConsts.operation.ToString()] != null)
            {
                operation = (string)ViewState[ViewStateConsts.operation.ToString()];
            }
                operation = b.Text;
            ViewState[ViewStateConsts.operation.ToString()] = (object)operation;

            if (ViewState[ViewStateConsts.value.ToString()] != null)
            {
                value = (double)ViewState[ViewStateConsts.value.ToString()];
            }
            value = double.Parse(result.Text);
            ViewState[ViewStateConsts.value.ToString()] = (object)value;
            ViewState[ViewStateConsts.text.ToString()] = null;

            clickOperation = true;
            ViewState[ViewStateConsts.clickOperation.ToString()] = (object)clickOperation;
            

        }
        //Кнопка С
        protected void Button11_Click(object sender, EventArgs e)
        {
            ViewState[ViewStateConsts.text.ToString()] = (object)result.Text;

            if (ViewState[ViewStateConsts.text.ToString()] != null)
            {
                result.Text = (string)ViewState[ViewStateConsts.text.ToString()];
            }
            if (result.Text != "")
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            else
            {
                ViewState[ViewStateConsts.text.ToString()] = null;
                ViewState[ViewStateConsts.clickOperation.ToString()] = null;
                clickOperation = false;
                ViewState[ViewStateConsts.clickOperation.ToString()] = (object)clickOperation;
            }
            


        }

        protected void Button13_Click(object sender, EventArgs e)
        {

            if (ViewState[ViewStateConsts.text.ToString()] != null)
            {
                result.Text = (string)ViewState[ViewStateConsts.text.ToString()];
            }
            result.Text = (string)ViewState[ViewStateConsts.text.ToString()];
            if (ViewState[ViewStateConsts.operation.ToString()] != null)
            {
                operation = (string)ViewState[ViewStateConsts.operation.ToString()];
            }
            if (ViewState[ViewStateConsts.value.ToString()] != null)
            {
                value = (double)ViewState[ViewStateConsts.value.ToString()];
            }

            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value/ double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value*double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            clickOperation = false;
            ViewState[ViewStateConsts.clickOperation.ToString()] =null;
            ViewState[ViewStateConsts.text.ToString()] = (object)"";
        }
    }
}
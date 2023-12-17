using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calcolatrice : System.Web.UI.Page
{

    //DICHIARAZIONE VARIABILI GLOBALI
    static string num1 = "";
    static string num2 = "";
    static string op = "";

    static float num1f; //variabile float di appoggio a variabile num1 nei casi in cui serve come numero e non come stringa
    static float num2f; //variabile float di appoggio a variabile num2 nei casi in cui serve come numero e non come stringa
    static float tot;

    static int flag = 0;





    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //EVENTI BOTTONI NUMERO
    protected void btnCanc_Click(object sender, EventArgs e)
    {
        num1 = "";
        num2 = "";
        op = "";
        flag = 0;

        txtDisplay.Text = "";
    }


    protected void btn0_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }

        if (op == "")
        {

            if (txtDisplay.Text == "")
            {
                num1 += "0";
                txtDisplay.Text = num1;
            }
            else
            {
                if (txtDisplay.Text != "" && txtDisplay.Text != "0")
                {
                    num1 += "0";
                    txtDisplay.Text = num1;
                }
            }



        }
        else
        {

            if (txtDisplay.Text != "")
            {
                if (txtDisplay.Text != "0")
                {
                    num2 += "0";
                    txtDisplay.Text = num2;
                }
            }


        }
    }


    protected void btn1_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }

        if (op == "")
        {
            num1 += "1";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "1";
            txtDisplay.Text = num2;
        }
    }


    protected void btn2_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "2";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "2";
            txtDisplay.Text = num2;
        }
    }

    protected void btn3_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "3";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "3";
            txtDisplay.Text = num2;
        }
    }

    protected void btn4_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "4";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "4";
            txtDisplay.Text = num2;
        }
    }

    protected void btn5_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "5";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "5";
            txtDisplay.Text = num2;
        }
    }

    protected void btn6_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "6";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "6";
            txtDisplay.Text = num2;
        }
    }

    protected void btn7_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "7";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "7";
            txtDisplay.Text = num2;
        }
    }

    protected void btn8_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "8";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "8";
            txtDisplay.Text = num2;
        }
    }

    protected void btn9_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = "";
            num2 = "";
            op = "";
            flag = 0;
            txtDisplay.Text = "";
        }


        if (op == "")
        {
            num1 += "9";
            txtDisplay.Text = num1;
        }
        else
        {
            num2 += "9";
            txtDisplay.Text = num2;
        }
    }

    //EVENTI BOTTONI OPERATORE


    protected void btnAddizione_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = txtDisplay.Text;
            num2 = "";
            op = "+";
            flag = 0;
        }


        if (num1 != "")
        {
            if (num2 == "")
            {
                op = "+";
            }
            else
            {
                //CONTROLLO OPERATORE
                if (op == "+")
                {
                    tot = float.Parse(num1) + float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "-")
                {
                    tot = float.Parse(num1) - float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "*")
                {
                    tot = float.Parse(num1) * float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "/")
                {
                    tot = float.Parse(num1) / float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                //FINE CONTROLLO OPERATORE

                num1 = tot.ToString();
                txtDisplay.Text = num1;
                num2 = "";
                op = "+";
            }
        }
    }

    protected void btnSottrazione_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = txtDisplay.Text;
            num2 = "";
            op = "-";
            flag = 0;
        }

        if (num1 != "")
        {
            if (num2 == "")
            {
                op = "-";
            }
            else
            {
                //CONTROLLO OPERATORE
                if (op == "+")
                {
                    tot = float.Parse(num1) + float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "-")
                {
                    tot = float.Parse(num1) - float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "*")
                {
                    tot = float.Parse(num1) * float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "/")
                {
                    tot = float.Parse(num1) / float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                //FINE CONTROLLO OPERATORE

                num1 = tot.ToString();
                txtDisplay.Text = num1;
                num2 = "";
                op = "-";
            }
        }
    }

    protected void btnMoltiplicazione_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = txtDisplay.Text;
            num2 = "";
            op = "*";
            flag = 0;
        }

        if (num1 != "")
        {
            if (num2 == "")
            {
                op = "*";
            }
            else
            {
                //CONTROLLO OPERATORE
                if (op == "+")
                {
                    tot = float.Parse(num1) + float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "-")
                {
                    tot = float.Parse(num1) - float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "*")
                {
                    tot = float.Parse(num1) * float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "/")
                {
                    tot = float.Parse(num1) / float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                //FINE CONTROLLO OPERATORE
                num1 = tot.ToString();
                txtDisplay.Text = num1;
                num2 = "";
                op = "*";
            }
        }
    }

    protected void btnDivisione_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        { //controllo se è in corso un operazione o se è nesessario ricominciare a seguito di un uguale

            num1 = txtDisplay.Text;
            num2 = "";
            op = "/";
            flag = 0;
        }


        if (num1 != "")
        {
            if (num2 == "")
            {
                op = "/";
            }
            else
            {
                //CONTROLLO OPERATORE
                if (op == "+")
                {
                    tot = float.Parse(num1) + float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "-")
                {
                    tot = float.Parse(num1) - float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "*")
                {
                    tot = float.Parse(num1) * float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                if (op == "/")
                {
                    tot = float.Parse(num1) / float.Parse(num2);
                    txtDisplay.Text = tot.ToString();
                }
                //FINE CONTROLLO OPERATORE

                num1 = tot.ToString();
                txtDisplay.Text = num1;
                num2 = "";
                op = "/";
            }
        }
    }


    //EVENTI BOTTONE UGUALE

    protected void btnUguale_Click(object sender, EventArgs e)
    {



        if (num1 != "")
        {
            if (num2 != "")
            {
                if (op == "/" && num2 == "0")
                {
                    txtDisplay.Text = "Errore";
                }
                else
                {
                    if (op == "+")
                    {
                        tot = float.Parse(num1) + float.Parse(num2);
                        txtDisplay.Text = tot.ToString();
                        num1 = tot.ToString();
                        num2 = "";
                        op = "";
                    }
                    if (op == "-")
                    {
                        tot = float.Parse(num1) - float.Parse(num2);
                        txtDisplay.Text = tot.ToString();
                        num1 = tot.ToString();
                        num2 = "";
                        op = "";
                    }
                    if (op == "*")
                    {
                        tot = float.Parse(num1) * float.Parse(num2);
                        txtDisplay.Text = tot.ToString();
                        num1 = tot.ToString();
                        num2 = "";
                        op = "";
                    }
                    if (op == "/")
                    {
                        tot = float.Parse(num1) / float.Parse(num2);
                        txtDisplay.Text = tot.ToString();
                        num1 = tot.ToString();
                        num2 = "";
                        op = "";
                    }

                    flag = 1; //per segnarmi che ho appena concluso un operazione
                }
            }
        }
    }



    //EVENTI BOTTONE NEGATIVO

    protected void btnNegativo_Click(object sender, EventArgs e)
    {

        if (txtDisplay.Text != "")
        {
            num1f = float.Parse(txtDisplay.Text);

            if (num1f > 0)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
                num1 = txtDisplay.Text;
                op = "";
                num2 = "";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
                num1 = txtDisplay.Text;
                op = "";
                num2 = "";
            }
        }

    }

    //EVENTI BOTTONE PERCENTUALE

    protected void btnPercentuale_Click(object sender, EventArgs e)
    {
        if (txtDisplay.Text != "")
        {

            if (op == "")
            {
                num1f = 0;
                num1f = float.Parse(num1) / 100;
                num1 = num1f.ToString();
                txtDisplay.Text = num1;
            }
            else
            {
                num2f = 0;
                num2f = float.Parse(num2) / 100;
                num2 = num2f.ToString();
                txtDisplay.Text = num2;
            }
        }
    }

    //EVENTI BOTTONE DECIMALE



    protected void btnDecimale_Click(object sender, EventArgs e)
    {

        if (txtDisplay.Text == "")
        {
            num1 += "0,";
            txtDisplay.Text = num1;
        }
        else
        {
            if (op == "")
            {

                num1 += ",";
                txtDisplay.Text = num1;
            }
            else
            {
                num2 += ",";
                txtDisplay.Text = num2;
            }
        }
    }
}
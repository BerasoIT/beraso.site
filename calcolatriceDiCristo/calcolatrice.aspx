<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calcolatrice.aspx.cs" Inherits="calcolatrice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calcolatrice</title>
    <link href="style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        
        <%--<div id="contenitore">--%>
            <table>

                <tr>
                    <td colspan="4">
                        <asp:TextBox ID="txtDisplay" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td>
                        <asp:Button ID="btnCanc" class="bottoneFunzione" runat="server" Text="C" OnClick="btnCanc_Click" /></td>
                    <td>
                        <asp:Button ID="btnNegativo" class="bottoneFunzione" runat="server" Text="+/-" OnClick="btnNegativo_Click" /></td>
                    <td>
                        <asp:Button ID="btnPercentuale" class="bottoneFunzione" runat="server" Text="%" OnClick="btnPercentuale_Click" /></td>
                    <td>
                        <asp:Button ID="btnDivisione" class="bottoneOperatori" runat="server" Text="÷" OnClick="btnDivisione_Click" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btn7" class="bottoneNumeri" runat="server" Text="7" OnClick="btn7_Click" /></td>
                    <td>
                        <asp:Button ID="btn8" class="bottoneNumeri" runat="server" Text="8" OnClick="btn8_Click" /></td>
                    <td>
                        <asp:Button ID="btn9" class="bottoneNumeri" runat="server" Text="9" OnClick="btn9_Click" /></td>
                    <td>
                        <asp:Button ID="btnMoltiplicazione" class="bottoneOperatori" runat="server" Text="x" OnClick="btnMoltiplicazione_Click" /></td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btn4" class="bottoneNumeri" runat="server" Text="4" OnClick="btn4_Click" /></td>
                    <td>
                        <asp:Button ID="btn5" class="bottoneNumeri" runat="server" Text="5" OnClick="btn5_Click" /></td>
                    <td>
                        <asp:Button ID="btn6" class="bottoneNumeri" runat="server" Text="6" OnClick="btn6_Click" /></td>
                    <td>
                        <asp:Button ID="btnSottrazione" class="bottoneOperatori" runat="server" Text="-" OnClick="btnSottrazione_Click" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btn1" class="bottoneNumeri" runat="server" Text="1" OnClick="btn1_Click" /></td>
                    <td>
                        <asp:Button ID="btn2" class="bottoneNumeri" runat="server" Text="2" OnClick="btn2_Click" /></td>
                    <td>
                        <asp:Button ID="btn3" class="bottoneNumeri" runat="server" Text="3" OnClick="btn3_Click" /></td>
                    <td>
                        <asp:Button ID="btnAddizione" class="bottoneOperatori" runat="server" Text="+" OnClick="btnAddizione_Click" />
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn0" class="bottoneNumeri" runat="server" Text="0" OnClick="btn0_Click" /></td>
                    <td>
                        <asp:Button ID="btnDecimale" class="bottoneNumeri" runat="server" Text="," OnClick="btnDecimale_Click" /></td>
                    <td>
                        <asp:Button ID="btnUguale" class="bottoneOperatori" runat="server" Text="=" OnClick="btnUguale_Click" /></td>
                </tr>


            </table>

        <%--</div>--%>
    </form>
</body>
</html>

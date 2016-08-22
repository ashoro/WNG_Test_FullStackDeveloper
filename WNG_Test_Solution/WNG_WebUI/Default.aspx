<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WNG_WebUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/font-awesome.min.css" rel="stylesheet" />
    <link href="Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="pg_wrp" name="App_form">
        <div class="instr_wrp">
            <h1>Welcome to Sequence Generator</h1>
            <h3>Please follow steps below to use this application and have fun.</h3>
            <br />
            <ul>
                <li>
                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                    1. Enter a posstive number in text box [Hint: try smaller numbers at first to understand the sequence fun]
                </li>
                <li>
                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                   2. Pree Submit button and wait for results to be loaded
                </li>
                <li>
                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                    3. Enjoy the result !
                </li>
                  
            </ul>

            <input type="button" value="Start Now" class="btn startNow" />
        </div><!-- end instruction section-->

        <div class="inputs_wrp">
            
            <asp:TextBox runat="server" ID="txt_inputNr" CssClass="input_field" placeholder="Enter a positive number" ValidationGroup="A" ></asp:TextBox>
            <asp:Button runat="server" Text="Submit" CssClass="btn btn_purple" ID="btn_submit" OnClick="btn_submit_Click"/>
            <p class="error_msg"></p>
        </div>
        <div class="result_wrp">
            <h1>Result page</h1>
            <div class="row clearfix">
                <div class="col-2"></div>
                <div class="col-2"></div>
            </div>
        </div>
    </form>
    <script src="scripts/jquery-3.1.0.min.js"></script>
    <script src="scripts/Script.js"></script>
</body>
</html>

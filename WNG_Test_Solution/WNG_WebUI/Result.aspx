<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WNG_WebUI.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Styles/font-awesome.min.css" rel="stylesheet" />
    <link href="Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="pg_wrp" name="App_form">
      

    
        <div class="result_wrpB">
            <h1>Result for : <asp:Label ID="lblNumber" runat="server"></asp:Label></h1>
            <div class="row clearfix">
                <div class="col-2">All numbers up to and including the number entered</div>
                <div class="col-2"><asp:Label ID="lblResult1" runat="server"></asp:Label></div>
            </div>
              <div class="row clearfix">
                <div class="col-2">All odd numbers up to and including the number entered</div>
                <div class="col-2"><asp:Label ID="lblResult2" runat="server"></asp:Label></div>
            </div>
              <div class="row clearfix">
                <div class="col-2">All even numbers up to and including the number entered</div>
                <div class="col-2"><asp:Label ID="lblResult3" runat="server"></asp:Label></div>
            </div>
              <div class="row clearfix">
                <div class="col-2">
                    All numbers up to and including the number entered, except  when, 
                     <br /> * A number is a multiple of 3 output C, and when,  
                    <br /> * A number is a multiple of 5 output E, and when,  
                     <br /> * A number is a multiple of both 3 and 5 output Z,  
                </div>
                <div class="col-2"><asp:Label ID="lblResult4" runat="server"></asp:Label></div>
            </div>
              <div class="row clearfix">
                <div class="col-2">
                    All fibonacci number up to and including the number entered

                </div>
                <div class="col-2"><asp:Label ID="lblResult5" runat="server"></asp:Label></div>
            </div>
        
             <asp:Button runat="server" Text="Start Over" CssClass="btn btn_purple" ID="btnStartOver" OnClick="btnStartOver_Click"/>
        </div>
    </form>
    <script src="scripts/jquery-3.1.0.min.js"></script>
    <script src="scripts/Script.js"></script>
</body>
</html>

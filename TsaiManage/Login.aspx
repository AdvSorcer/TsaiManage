<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TsaiManage.Login" %>

<%@ Register Src="~/UserControl/ucHead.ascx" TagPrefix="uc1" TagName="ucHead" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<uc1:ucHead runat="server" ID="ucHead" />
<body>
    <form id="form1" runat="server">
        <div id="container" style="margin-top:100px">
            <div class="row">
                <div class="col-2"></div>
                <div class="col">
                    <div id="login">
                        <div class="form-group">
                            <label for="exampleInputPassword1">請輸入密碼</label>
                            <input type="password" class="form-control" id="input_pw" runat="server" placeholder="Password"/>
                        </div>
                        <asp:Button ID="btn_submit" runat="server" Text="確認"  class="btn btn-primary" OnClick="btn_submit_Click"/>
                    </div>
                </div>
                <div class="col-2"></div>
            </div>

        </div>
    </form>
</body>
</html>

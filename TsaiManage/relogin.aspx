<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="relogin.aspx.cs" Inherits="TsaiManage.relogin" %>

<%@ Register Src="~/UserControl/ucHead.ascx" TagPrefix="uc1" TagName="ucHead" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<uc1:ucHead runat="server" ID="ucHead" />
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <asp:Button ID="btn_reload" runat="server" Text="重新登入" CssClass="btn btn-primary" OnClick="btn_reload_Click" style=" margin-top:100px" />
            </div>
            <div class="col"></div>
        </div>
    </form>
</body>
</html>

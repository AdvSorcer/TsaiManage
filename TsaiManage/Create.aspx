<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="TsaiManage.Create" %>

<%@ Register Src="~/UserControl/UcNavBar.ascx" TagPrefix="uc1" TagName="UcNavBar" %>
<%@ Register Src="~/UserControl/ucHead.ascx" TagPrefix="uc1" TagName="ucHead" %>
<%@ Register Src="~/UserControl/ucIdentify.ascx" TagPrefix="uc1" TagName="ucIdentify" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<uc1:ucHead runat="server" ID="ucHead" />
<body>
    <form id="form1" runat="server">
        <uc1:UcNavBar runat="server" ID="UcNavBar" />
        <uc1:ucIdentify runat="server" id="ucIdentify" />
        <div id="container">
            <div class="d-flex justify-content-center">
                <table>
                    <tr>
                        <td>項目 : </td>
                        <td>
                            <asp:TextBox ID="tbx_item" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>收入 : </td>
                        <td>
                            <asp:TextBox ID="tbx_income" runat="server"></asp:TextBox>
                            純數字 (無也要輸入0)
                   
                        </td>
                    </tr>
                    <tr>
                        <td>支出 : </td>
                        <td>
                            <asp:TextBox ID="tbx_price" runat="server"></asp:TextBox>
                            純數字 (無也要輸入0)
                   
                        </td>
                    </tr>
                    <tr>
                        <td>人名 : </td>
                        <td>
                            <asp:TextBox ID="tbx_name" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>日期 : </td>
                        <td>
                            <asp:TextBox ID="tbx_date" runat="server"></asp:TextBox>
                            ex:2020/01/01
                        </td>
                    </tr>
                </table>
            </div>
            <div style="height: 20px;">
            </div>
            <div class="d-flex justify-content-center">
                <asp:Button ID="btn_ok" CssClass="btn btn-primary" runat="server" Text="送出" OnClick="btn_ok_Click" />
                <div style="width: 20px"></div>
                <asp:Button ID="btn_cancel" CssClass="btn btn-secondary" runat="server" Text="取消" OnClick="btn_cancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>

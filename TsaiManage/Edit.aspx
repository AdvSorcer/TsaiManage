<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="TsaiManage.Edit" %>

<%@ Register Src="~/UserControl/UcNavBar.ascx" TagPrefix="uc1" TagName="UcNavBar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>微帳本</title>
    <!-- CSS only -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">

    <!-- JS, Popper.js, and jQuery -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div id="container">

            <uc1:ucnavbar runat="server" id="UcNavBar" />

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

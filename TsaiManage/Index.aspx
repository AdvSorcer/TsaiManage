<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TsaiManage.Index" Debug="true" %>

<%@ Register Src="~/UserControl/UcNavBar.ascx" TagPrefix="uc1" TagName="UcNavBar" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>紀錄系統</title>
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

            <uc1:UcNavBar runat="server" ID="UcNavBar" />

            <div class="alert alert-light" role="alert">
                餘額 :
                <asp:Literal ID="Lit_rest" runat="server"></asp:Literal>
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" DataKeyNames="id" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="item" HeaderText="項目" />
                        <asp:BoundField DataField="income" HeaderText="收入" />
                        <asp:BoundField DataField="price" HeaderText="支出" />
                        <asp:BoundField DataField="name" HeaderText="人" />
                        <asp:BoundField DataField="costdate" HeaderText="日期" />
                        <asp:ButtonField CommandName="up" Text="編輯"  />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>

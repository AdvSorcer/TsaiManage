<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Flower.aspx.cs" Inherits="TsaiManage.Flower" Debug="true" %>

<%@ Register Src="~/UserControl/UcNavBar.ascx" TagPrefix="uc1" TagName="UcNavBar" %>
<%@ Register Src="~/UserControl/ucHead.ascx" TagPrefix="uc1" TagName="ucHead" %>
<%@ Register Src="~/UserControl/ucIdentify.ascx" TagPrefix="uc1" TagName="ucIdentify" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<uc1:ucHead runat="server" id="ucHead" />
<body>
    <form id="form1" runat="server">
        <div id="container">

            <uc1:UcNavBar runat="server" ID="UcNavBar" />
            <uc1:ucIdentify runat="server" ID="ucIdentify" />

            <div class="alert alert-light" role="alert">
                餘額 :
                <asp:Literal ID="Lit_rest" runat="server"></asp:Literal>
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" DataKeyNames="id" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="object" HeaderText="項目" />
                        <asp:BoundField DataField="who" HeaderText="贈送者" />
                        <asp:BoundField DataField="count" HeaderText="數量" />
                        <asp:BoundField DataField="send_date" HeaderText="日期" />
                        <asp:ButtonField CommandName="up" Text="編輯"  />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>

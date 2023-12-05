<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="EOWeb.htmls.Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            QueryString:<asp:Label ID="label_QyeryString" runat="server"></asp:Label>
            <br />
            params:<asp:Label ID="label_params" runat="server"></asp:Label>
            <br />
            Url:<asp:Label ID="label_url" runat="server" />
            <br />
            userHostAddress:<asp:Label ID="label_userHostAddress" runat="server" />
            <br />
            islocal:<asp:Label ID="label_islocal" runat="server" />
            <br />
            Browser:<asp:Label ID="label_browser" runat="server" />
        </div>
    </form>
</body>
</html>

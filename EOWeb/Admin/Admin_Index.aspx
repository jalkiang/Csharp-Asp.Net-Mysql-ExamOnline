﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Index.aspx.cs" Inherits="EOWeb.Admin.Admin_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="~/css/Admin.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div  class="top">
            <div>
                <h1>在线考试系统 · 管理员</h1>
            </div> 
        </div>
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">退出登录</asp:LinkButton>
        </div>
    </form>
</body>
</html>

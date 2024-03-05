<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="teacherRegister.aspx.cs" Inherits="EOWeb.htmls.teacherRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/css/LoginAndRegister.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>注册</h1>已有账号？<asp:HyperLink ID="hyperlink1" runat="server" NavigateUrl="~/htmls/teacherLogin.aspx">登录</asp:HyperLink>
        <div class="form_group">
            <asp:TextBox ID="tb_userName" CssClass="form_control" runat="server" TextMode="SingleLine" Placeholder="请输入账号"></asp:TextBox>
        </div>
        <div class="form_group">
            <asp:TextBox ID="tb_password" CssClass="form_control" runat="server" TextMode="Password" Placeholder="请输入密码"></asp:TextBox>
        </div>
        <div class="form_group">
            <asp:TextBox ID="tb_confirmPassword" CssClass="form_control" runat="server" TextMode="Password" Placeholder="确认密码"></asp:TextBox>
        </div>
        <div class="form_group"> 
            科目：<asp:DropDownList ID="DropDownList1" CssClass="ddl_subject" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">C#程序设计</asp:ListItem>
                <asp:ListItem>大学英语</asp:ListItem>
                <asp:ListItem>MYSQL数据库设计</asp:ListItem>
                <asp:ListItem>计算机组成原理</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form_group">
            <asp:Button ID="btn_Register" CssClass="form_control btn_Register" runat="server" Text="注册" OnClick="btn_Register_Click" />
        </div>
    </div>
</asp:Content>

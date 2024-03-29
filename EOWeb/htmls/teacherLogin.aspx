﻿
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="teacherLogin.aspx.cs" Inherits="EOWeb.htmls.techerLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="/css/LoginAndRegister.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>教师登录</h1>没有账号？<asp:HyperLink ID="hyperlink2" runat="server" NavigateUrl="~/htmls/teacherRegister.aspx">注册</asp:HyperLink>
        <div class="form_group">
            <asp:TextBox ID="tb_userName" CssClass="form_control" runat="server" TextMode="SingleLine" Placeholder="请输入账号"></asp:TextBox>
        </div>
        <div class="form_group">
            <asp:TextBox ID="tb_password" CssClass="form_control" runat="server" TextMode="Password" Placeholder="请输入密码"></asp:TextBox>
        </div>
        <div class="form_group">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="记住账号" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="自动登录" />
        </div>
        <div class="form_group">
            <asp:Button ID="btn_Login" CssClass="form_control btn_Login" runat="server" Text="登录" OnClick="btn_Login_Click" />
        </div>
        <div class="form_group sLogin">
            <asp:HyperLink ID="hyperlink1" runat="server" NavigateUrl="~/htmls/Login.aspx">学生登录</asp:HyperLink>
        </div>
    </div>
</asp:Content>

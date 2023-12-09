<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EOWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>登录<div>没有账号？注册</div></div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="tb_userName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>

    </div>
    <div>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="记住账号" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="自动登录" />
    </div>
    <div>
        <asp:Button ID="btn_Login" runat="server" Text="登录" OnClick="Button1_Click" />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Teacher_Pwdres.aspx.cs" Inherits="EOWeb.Teacher.Teacher_Pwdres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>修改密码</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="t_info_container">
        <div  class="t_info_top">
            <div class="line_ver"></div><div class="t_info_top_font">修改密码</div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                原密码:
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_oldpwd" CssClass="t_info_group_textbox" TextMode="Password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                新密码：
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_newpwd" CssClass="t_info_group_textbox" TextMode="Password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                确认密码：
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_conpwd" CssClass="t_info_group_textbox" TextMode="Password" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <asp:Button ID="btn_pwdres" CssClass="btn_save" runat="server" Text="更改密码" OnClick="btn_pwdres_Click" />
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Teacher_info.aspx.cs" Inherits="EOWeb.Teacher.Teacher_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="t_info_container">
        <div  class="t_info_top">
            <div class="line_ver"></div><div class="t_info_top_font">个人信息</div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                教师ID:
            </div>
            <div class="t_info_group_right">
                <asp:Label ID="lb_tId" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                教师姓名：
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_tName" CssClass="t_info_group_textbox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                手机号：
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_Subject" CssClass="t_info_group_textbox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <div class="t_info_group_left">
                科目：
            </div>
            <div class="t_info_group_right">
                <asp:TextBox ID="tb_tPhone" CssClass="t_info_group_textbox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="t_info_group">
            <asp:Button ID="btn_save" CssClass="btn_save" runat="server" Text="保存" OnClick="btn_save_Click" />
        </div>
    </div>
</asp:Content>

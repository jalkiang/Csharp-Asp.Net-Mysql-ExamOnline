<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Teacher_info.aspx.cs" Inherits="EOWeb.Teacher.Teacher_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="t_info_container">
        <div>
            <h1>个人信息</h1>
        </div>
        <div class="t_info_group">
            <div>
                教师ID:
            </div>
            <div>
                <asp:Label ID="lb_tId" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="t_info_group">
            <div>
                教师姓名：
            </div>
            <div>
                <asp:Label ID="lb_tName" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="t_info_group">
            <div>
                手机号：
            </div>
            <div>
                <asp:Label ID="lb_tPhone" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="t_info_group">
            <div>
                科目：
            </div>
            <div>
                <asp:Label ID="lb_Subject" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

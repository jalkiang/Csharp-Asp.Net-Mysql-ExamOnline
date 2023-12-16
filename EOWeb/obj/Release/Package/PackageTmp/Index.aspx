<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EOWeb.Index" MasterPageFile="~/Site1.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
    <div>
        <asp:LinkButton ID="LogoutButton" runat="server" OnClick="LogoutButton_Click" Text=<%#Session["UserName"] == null?"登录":"退出登录"%>></asp:LinkButton>
    </div>
    <div>
        <table>
            <tr>
                <th>姓名</th>
                <th>详细信息</th>
            </tr>
            <tr>
                <td>里</td>
                <td><a href="./htmls/Detail.aspx?num=666">详细信息</a></td>
            </tr>
            <tr>
                <td>里</td>
                <td><a href="./htmls/Detail.aspx?num=777">详细信息</a></td>
            </tr>
            <tr>
                <td>里</td>
                <td><a href="./htmls/Detail.aspx?num=888">详细信息</a></td>
            </tr>
        </table>
    </div>
</asp:Content>

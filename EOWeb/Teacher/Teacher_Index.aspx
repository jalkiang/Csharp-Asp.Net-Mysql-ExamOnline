<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher_Index.aspx.cs" Inherits="EOWeb.Teacher.Teacher_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>教师主页</title>
    <link rel="stylesheet" href="~/css/Admin.css" />
    <link rel="stylesheet" href="~/css/iconfont.css">

</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <div class="menu-box">
                    <!-- 侧边栏的标题 开始-->
                    <div class="menu-title">
                        <h1>主页</h1>
                    </div>

                    <div class="menu-item">
                        <input type="checkbox" id="menu-item1" />
                        <label for="menu-item1">                           
                            <span>账号管理</span>
                            <i class="menu-item-last">></i>
                        </label>
                        <div class="menu-content">
                            <span>个人信息</span>
                            <span>修改密码</span>
                            <span>option3</span>
                        </div>
                    </div>

                    <div class="menu-item">
                        <input type="checkbox" id="menu-item2" />
                        <label for="menu-item2">
                            <span>学生管理</span>
                            <i class="menu-item-last">></i>
                        </label>
                        <div class="menu-content">
                            <span>option1</span>
                            <span>option2</span>
                        </div>
                    </div>

                    <div class="menu-item">
                        <input type="checkbox" id="menu-item3" />
                        <label for="menu-item3">
                            <span>账号管理</span>
                            <i class="menu-item-last">></i>
                        </label>
                        <div class="menu-content">
                            <span>个人信息</span>
                            <span>修改密码</span>
                        </div>
                    </div>

                    <div class="set-line"></div>

                    <div class="menu-item">
                        <label>
                            <span>设置</span>
                        </label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

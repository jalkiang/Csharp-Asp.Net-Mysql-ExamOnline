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
                    <!-- 侧边栏的标题 结束-->

                    <!-- 每一项导航 -->
                    <div class="menu-item">
                        <input type="checkbox" id="menu-item1" />
                        <label for="menu-item1">
                            <i class="menu-item-icon iconfont icon-a-01-shujuzhongxin"></i>
                            <span>navigation1</span>
                            <i class="menu-item-last iconfont icon-down"></i>
                        </label>
                        <div class="menu-content">
                            <span>option1</span>
                            <span>option2</span>
                            <span>option3</span>
                        </div>
                    </div>

                    <div class="menu-item">
                        <input type="checkbox" id="menu-item2" />
                        <label for="menu-item2">
                            <i class="menu-item-icon iconfont icon-a-02-kechengguanli"></i>
                            <span>navigation2</span>
                            <i class="menu-item-last iconfont icon-down"></i>
                        </label>
                        <div class="menu-content">
                            <span>option1</span>
                            <span>option2</span>
                        </div>
                    </div>

                    <div class="menu-item">
                        <input type="checkbox" id="menu-item3" />
                        <label for="menu-item3">
                            <i class="menu-item-icon iconfont icon-a-04-zixunfabu"></i>
                            <span>navigation3</span>
                            <i class="menu-item-last iconfont icon-down"></i>
                        </label>
                        <div class="menu-content">
                            <span>option1</span>
                            <span>option2</span>
                            <span>option3</span>
                        </div>
                    </div>

                    <div class="set-line"></div>

                    <div class="menu-item">
                        <label>
                            <i class="menu-item-icon iconfont icon-a-08-shezhi"></i>
                            <span>setting</span>
                        </label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

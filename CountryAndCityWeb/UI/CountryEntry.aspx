<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryAndCityWeb.UI.CountryEntry" validateRequest="false"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Country Entry</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../floalaEditort/css/froala_editor.css" rel="stylesheet" />
    <link href="../floalaEditort/css/froala_style.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
<div class="wrapper">
    <header>
        <h1>Country Entry</h1>
    </header>
    <nav><ul>
        <li><a href="CountryEntry.aspx">Country Entry</a></li>
        <li><a href="CityEntry.aspx">City Entry</a></li>
        <li><a href="ViewCities.aspx">View Cities</a></li>
        <li><a href="ViewCountry.aspx">View Country</a></li>
         </ul></nav>
    <div class="Container">
        <div class="Content1">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="countryNameTextBox" runat="server" Width="142px"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="About:"></asp:Label><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <textarea id="edit" runat="server"></textarea><br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="saveButton" runat="server" Text="Save" Width="85px" OnClick="saveButton_Click" BackColor="#3399FF" Height="33px" /> &nbsp;&nbsp;
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" BackColor="#3399FF" Height="33px" Width="79px" />
            <br />
            <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
        </div>
        <div class="Content2">
            <div style='overflow-x:auto; width:940px '>
            <asp:GridView ID="countryGridView" runat="server" AutoGenerateColumns="False" Width="7px" >
                <Columns>
                    <asp:BoundField DataField="SerialNo" HeaderText="Serial No" SortExpression="SerialNo" />
                    <asp:BoundField DataField="CountryName" HeaderText="Name" SortExpression="CountryName" />
                    <asp:BoundField DataField="CountryAbout" HeaderText="About" SortExpression="CountryAbout" HtmlEncode="False"  HeaderStyle-Width="10px" HeaderStyle-HorizontalAlign="center">
<ItemStyle HorizontalAlign="Left" Width="10px"></ItemStyle>
                    </asp:BoundField>
                </Columns>

<RowStyle Wrap="True"></RowStyle>
            </asp:GridView>
                </div>
        </div>
    </div>
    <footer><p><a href="index.aspx">Back to main menu</a></p></footer>

</div>
        </form>

    <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../floalaEditort/js/froala_editor.min.js"></script>

    <script src="../floalaEditort/js/plugins/tables.min.js"></script>
    <script src="../floalaEditort/js/plugins/lists.min.js"></script>
    <script src="../floalaEditort/js/plugins/colors.min.js"></script>
    <script src="../floalaEditort/js/plugins/font_size.min.js"></script>
    <script src="../floalaEditort/js/plugins/font_family.min.js"></script>
    <script src="../floalaEditort/js/plugins/lists.min.js"></script>
    <script src="../floalaEditort/js/plugins/media_manager.min.js"></script>
    <script src="../floalaEditort/js/plugins/block_styles.min.js"></script>
    <script src="../floalaEditort/js/plugins/video.min.js"></script>

    <script>
        $(function () {
            $('#edit').editable({ inlineMode: false,height:100, alwaysBlank: true })
        });
  </script>
</body>

</html>
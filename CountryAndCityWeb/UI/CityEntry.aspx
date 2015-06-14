<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryAndCityWeb.UI.CityEntry" validateRequest="false"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>City Entry</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../floalaEditort/css/froala_editor.css" rel="stylesheet" />
    <link href="../floalaEditort/css/froala_style.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
<div class="wrapper">
    <header>
        <h1>City Entry</h1>
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
            <asp:TextBox ID="cityNameTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="About"></asp:Label>
            <textarea id="edit" runat="server"></textarea><br /><br />
            <asp:Label ID="Label3" runat="server" Text="No Of Dwellers"></asp:Label>
            <asp:TextBox ID="noOfDwellersTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
            <asp:TextBox ID="lacationTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label5" runat="server" Text="Weather"></asp:Label>
            <asp:TextBox ID="weatrerTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label6" runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="countryDropDownList" runat="server" Width="150px"></asp:DropDownList><br /><br />
            &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Height="32px" Width="68px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" Height="33px" OnClick="cancelButton_Click" Width="65px" />
            <br />
            <asp:Label ID="msgCityLabel" runat="server" Text=""></asp:Label>
        </div>
        <div class="Content2">
            <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="SerialNo" HeaderText="Serial No" SortExpression="SerialNo" />
                    <asp:BoundField DataField="CityName" HeaderText="Name" SortExpression="CityName" />
                    <asp:BoundField DataField="NoOfDwellers" HeaderText="No Of Dwellers" SortExpression="NoOfDwellers" />
                    <asp:BoundField DataField="aCountry.CountryName" HeaderText="Country" SortExpression="aCountry.CountryName" />
                </Columns>
            </asp:GridView>
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
            $('#edit').editable({ inlineMode: false, height:150, alwaysBlank: true })
        });

  </script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    cityNameTextBox: "required",
                    edit: "required",
                    noOfDwellersTextBox: "required",
                    lacationTextBox: "required",
                    weatrerTextBox: "required",
                },
                messages: {
                    cityNameTextBox: "Please enter City Name!",
                    noOfDwellersTextBox: "Please enter No of Dwellers!",
                    lacationTextBox:"Please enter location!",
                    weatrerTextBox: "Please enter weather!"
                }
            });
        });
    </script>
</body>

</html>
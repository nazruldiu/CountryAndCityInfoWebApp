<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountry.aspx.cs" Inherits="CountryAndCityWeb.UI.ViewCountry" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>View Country</title>
    <link href="Style.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
<div class="wrapper">
    <header>
        <h1>View Country</h1>
    </header>
    <nav><ul>
        <li><a href="CountryEntry.aspx">Country Entry</a></li>
        <li><a href="CityEntry.aspx">City Entry</a></li>
        <li><a href="ViewCities.aspx">View Cities</a></li>
        <li><a href="ViewCountry.aspx">View Country</a></li>
         </ul></nav>
    <div class="Container">
        <div class="Content1">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="countryNameTextBox" runat="server" Width="133px" Height="29px"></asp:TextBox>
            &nbsp; &nbsp;&nbsp;
            <asp:Button ID="SearchButton" runat="server" Text="Search" Width="89px" OnClick="SearchButton_Click" Height="33px" />
            <br />
            &nbsp; &nbsp;&nbsp;
            <asp:Label ID="msgSearchLabel" runat="server" Text=""></asp:Label>
            </div>
        <div class="Content2">
            <div style='overflow-x:auto; width:940px '>
            <asp:GridView ID="countrySearchGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="onPagging" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="SerialNo" HeaderText="Serial No" SortExpression="SerialNo" />
                    <asp:BoundField DataField="CountryName" HeaderText="Name" SortExpression="CountryName" />
                    <asp:BoundField DataField="CountryAbout" HeaderText="About" HtmlEncode="False" SortExpression="CountryAbout" />
                    <asp:BoundField DataField="aCity.SerialNo" HeaderText="No of City" SortExpression="aCity.SerialNo" />
                    <asp:BoundField DataField="aCity.TotalDwellers" HeaderText="No Of City Dwellers" SortExpression="aCity.TotalDwellers" />
                </Columns>
            </asp:GridView>
                </div>
        </div>
        </div>
     <footer><p><a href="index.aspx">Back to main menu</a></p></footer>
    </div>
        </form>
</body>

</html>
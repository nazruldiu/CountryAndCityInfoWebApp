<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryAndCityWeb.UI.ViewCities" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>View Cities</title>
    <link href="Style.css" rel="stylesheet" />
</head>

<body>
     <form id="form1" runat="server">
         <div class="wrapper">
    <header>
        <h1>View Cities</h1>
    </header>
             <nav><ul>
        <li><a href="CountryEntry.aspx">Country Entry</a></li>
        <li><a href="CityEntry.aspx">City Entry</a></li>
        <li><a href="ViewCities.aspx">View Cities</a></li>
        <li><a href="ViewCountry.aspx">View Country</a></li>
         </ul></nav>
    <div class="Container">
        <div class="Content1">

         <asp:RadioButton ID="cityRadioButton" runat="server" text="City Name" GroupName="search"/>
         <asp:TextBox ID="citiViweTextBox" runat="server" Height="24px"></asp:TextBox><br /><br />
         <asp:RadioButton ID="countryRadioButton" runat="server" text="Country" GroupName="search"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:DropDownList ID="countryDropDownList" runat="server" Height="49px" Width="154px"></asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" Height="35px" Width="72px" />
            <br /><br />
            </div>
        <div class="Content2">
            <div style='overflow-x:auto; width:940px '>
            <asp:GridView ID="viewCityGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="onPagging" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="SerialNo" HeaderText="Serial No" SortExpression="SerialNo" />
                    <asp:BoundField DataField="CityName" HeaderText="City Name" SortExpression="CityName" />
                    <asp:BoundField DataField="CityAbout" HeaderText="About" SortExpression="CityAbout" HtmlEncode="False" />
                    <asp:BoundField DataField="NoOfDwellers" HeaderText="No Of Dwellers" SortExpression="NoOfDwellers" />
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    <asp:BoundField DataField="Weather" HeaderText="Weather" SortExpression="Weather" />
                    <asp:BoundField DataField="aCountry.CountryName" HeaderText="Country" SortExpression="aCountry.CountryName" />
                    <asp:BoundField DataField="aCountry.CountryAbout" HeaderText="About Country" SortExpression="aCountry.CountryAbout" HtmlEncode="False" />
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
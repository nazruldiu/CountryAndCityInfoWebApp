<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CountryAndCityWeb.UI.index" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Main Menu</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
<div class="wrapper">
    <div class="mainmenu"><ul>
        <li><a href="CountryEntry.aspx">Country Entry</a></li>
        <li><a href="CityEntry.aspx">City Entry</a></li>
        <li><a href="ViewCities.aspx">View Cities</a></li>
        <li><a href="ViewCountry.aspx">View Country</a></li>
         </ul>
        </div>
    </div>
        </form>
    <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    </body>
    </html>
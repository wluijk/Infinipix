<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestCreatingJsonRPCClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <head>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.BigInt.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.IO.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Text.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Convert.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.BitConverter.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Security.Cryptography.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Security.Cryptography.SHA1.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Security.Cryptography.HMACSHA1.debug.js"></script>
        <script src="Scripts/JocysComJavaScriptClasses/System.Security.Cryptography.RSA.debug.js"></script>
        <script type="text/javascript">
            /*********************************************************************************
            ** doRSAEncrypt() - Encrypt a username and password that was in the textbox using the public key that was retrieved
            ** from the JSON-RPC web service.
            **
            ** Author: ameja
            ** Date: 1/25/2018
            **********************************************************************************/
            function doRSAEncrypt() {
                // Create the username and password string to encrypt
                var text = document.getElementById('<%= usernamePasswordText.ClientID %>').value;
                // Use OAEP padding (PKCS#1 v2).
                var doOaepPadding = true;
                // RSA 512-bit key: Public (Modulus + Exponent)
                var xmlParams = document.getElementById('<%= lblPublicKey.ClientID %>').innerHTML;
                var rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
                // Import parameters from XML string.
                rsa.FromXmlString(xmlParams);
                //Get the parameters from the public key returned
                var rsaParamsPublic = rsa.ExportParameters(false);
                //Get the bytes translation of the username/password combination
                var decryptedBytes = System.Text.Encoding.UTF8.GetBytes(text);
                // Create a new instance of RSACryptoServiceProvider.
                rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
                // Import the RSA Key information.
                rsa.ImportParameters(rsaParamsPublic);
                // Encrypt byte array.
                var encryptedBytes = rsa.Encrypt(decryptedBytes, doOaepPadding);
                // Convert bytes to base64 string.
                var encryptedString = System.Convert.ToBase64String(encryptedBytes);
                //alert(encryptedString);
                document.getElementById('<%= encryptedText.ClientID %>').value = encryptedString;
            }
        </script>
        <style type="text/css">
            .lblToken {
                word-wrap: break-word;
            }
        </style>
    </head>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="errorLabel" runat="server" BackColor="Red"></asp:Label>
            <asp:Label ID="successLabel" runat="server" BackColor="LightGreen"></asp:Label>
            <table>
                <tr>
                    <td>IP Address:</td>
                    <td>
                        <asp:TextBox ID="ipAddressText" AutoPostBack="true" OnTextChanged="ipAddressText_TextChanged"
                             runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Public Key:</td>
                    <td>
                        <asp:Label ID="lblPublicKey" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn1" Text="Get Public Key" runat="server" OnClick="btn1_Click" /></td>
                </tr>
                <tr>
                    <td>Username and password combo:</td>
                    <td>
                        <asp:TextBox ID="usernamePasswordText" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="clientButton" runat="server" Text="Encrypt" OnClientClick="doRSAEncrypt()" />
                        <asp:Button ID="btnAuthenticate" runat="server" Text="Authenticate" OnClick="btnAuthenticate_Click" /></td>
                </tr>
                <tr>
                    <td>Encrypted Text:</td>
                    <td>
                        <asp:TextBox ID="encryptedText" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Authenticated Token:</td>
                    <td>
                        <asp:Label ID="lblAuthenticatedToken" runat="server" CssClass="lblToken"></asp:Label></td>
                </tr>
                <tr>
                    <td>Display System Id:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDisplaySystemIds" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnDisplaySystemIds" runat="server" Text="Get" OnClick="btnDisplaySystemIds_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>Active Source:</td>
                    <td>
                        <asp:TextBox ID="activeSourceText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnActiveSource" runat="server" Text="Get" OnClick="btnActiveSource_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>Source Position and output size:
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>X:
                    </td>
                    <td>
                        <asp:TextBox ID="txtXPosition" runat="server" /></td>
                </tr>
                <tr>
                    <td>Y:</td>
                    <td>
                        <asp:TextBox ID="txtYPosition" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Width:</td>
                    <td>
                        <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Height:</td>
                    <td>
                        <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetSourcePosition" runat="server" Text="Get" OnClick="btnGetSourcePosition_Click" />
                        <asp:Button ID="btnSetSourcePosition" runat="server" Text="Set" OnClick="btnSetSourcePosition_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>Test Pattern Settings:</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Test Pattern Settings As Text:</td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettings" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Red:</td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettingRed" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Green:</td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettingGreen" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Blue:</td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettingBlue" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Movement:</td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettingMovement" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Direction:
                    </td>
                    <td>
                        <asp:TextBox ID="txtTestPatternSettingDirection" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Movement as checkbox:
                    </td>
                    <td>
                        <asp:CheckBox ID="chkMovement" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Available Directions:</td>
                    <td>
                        <asp:DropDownList ID="ddlDirections" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Available Test Patterns:</td>
                    <td>
                        <asp:DropDownList ID="ddlAvailableTestPatterns" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetTestPatternSettings" runat="server" Text="Get" OnClick="btnGetTestPatternSettings_Click" />
                        <asp:Button ID="btnSetTestPatternSettings" runat="server" Text="Set" OnClick="btnSetTestPatternSettings_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>
                        Available Sources:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlAvailableSources" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetAvailableSources" runat="server" Text="Get" OnClick="btnGetAvailableSources_Click1" />
                    </td>
                </tr>
                <tr>
                    <td>Source Settings:</td>
                    <td>
                        <asp:TextBox ID="txtSourceSettings" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Source Settings:</td>
                    <td>
                        <asp:TextBox ID="txtSourceSettingArea" runat="server" TextMode="MultiLine" Rows="10"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Brightness:</td>
                    <td>
                        <asp:TextBox ID="txtBrightness" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetSourceSettings" runat="server" Text="Get" OnClick="btnGetSourceSettings_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>Display Systems:</td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="txtDisplaySystems" runat="server" TextMode="MultiLine" Rows="20" Columns="100"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetDisplaySystems" Text="Get" runat="server" OnClick="btnGetDisplaySystems_Click" />
                        <asp:Button ID="btnSetDisplaySystems" Text="Set" runat="server" OnClick="btnSetDisplaySystems_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

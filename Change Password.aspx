<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>Banks'R'Us Change Password</title>    
</head>
<body>
    <form id="form1" runat="server"> 
       <table>
           <tr>
               <td>
                   Old Password:</td>
               <td>
                   <asp:TextBox ID="OldPassword" runat = "server"/>
                   <asp:RequiredFieldValidator ID = "ValidateOldPassword" ControlToValidate = "OldPassword" runat = "server" ErrorMessage = "** Old Password is Required!**" />
               </td>
           </tr>
           <tr>
               <td>
                   New Password:
               </td>
               <td>
                   <asp:TextBox ID="NewPassword" runat = "server"/>
                   <asp:RequiredFieldValidator ID = "ValidateNewPassword" ControlToValidate = "NewPassword" runat = "server" ErrorMessage = "**New Password is Required!**" />
               </td>
               </tr>
           <tr>
               <td>
                   Confirm New Password:
               </td>
               <td>
                   <asp:TextBox ID="ConfirmNewPassword" runat = "server"/>
                   <asp:RequiredFieldValidator ID = "ValidateConfirmPassword" ControlToValidate = "ConfirmNewPassword" runat = "server" ErrorMessage = "**Confirm Password is Required!**" />
               </td>
           </tr>
           <tr>
               <td>
                   <asp:Button ID="ChangePassword" Text="Change Password" runat = "server" />
               </td>
               <td>
                   <asp:Button ID="ResetForm" Text="Reset" runat = "server" />
               </td>
           </tr>
       </table>
    </form>
</body>
</html>

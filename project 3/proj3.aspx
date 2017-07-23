<%@ Page Language="C#" AutoEventWireup="true" CodeFile="proj3.aspx.cs" Inherits="proj2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="112px" Width="98px">
            <asp:ListItem>add</asp:ListItem>
            <asp:ListItem>sub</asp:ListItem>
            <asp:ListItem>mult</asp:ListItem>
            <asp:ListItem>divide</asp:ListItem>
        </asp:CheckBoxList>
    

    </div>
        <asp:CheckBoxList ID="CheckBoxList2" runat="server" Height="139px" Width="138px">
            <asp:ListItem>addcomp</asp:ListItem>
            <asp:ListItem>subcomp</asp:ListItem>
            <asp:ListItem>multcomp</asp:ListItem>
            <asp:ListItem>divcomp</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
        <br />
        <br />
        <asp:Button ID="adds" runat="server" OnClick="adds_Click" Text="add" Visible="False" />
        <asp:Button ID="subs" runat="server" OnClick="subs_Click" Text="sub" Visible="False" />
        <asp:Button ID="mults" runat="server" OnClick="mults_Click" Text="mult" Visible="False" />
        <asp:Button ID="divs" runat="server" OnClick="divs_Click" Text="div" Visible="False" />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addComp" runat="server" OnClick="addComp_Click" Text="addComp" Visible="False" />
        <asp:Button ID="subComp" runat="server" OnClick="subComp_Click" Text="subComp" Visible="False" />
        <asp:Button ID="multComp" runat="server" OnClick="multComp_Click" Text="multComp" Visible="False" />
        <asp:Button ID="divComp" runat="server" OnClick="divComp_Click" Text="divComp" Visible="False" />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" Visible="False"></asp:TextBox>
        <br />
        <hr />
        <br />
        <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" Visible="False"></asp:TextBox>
    </form>
</body>
</html>

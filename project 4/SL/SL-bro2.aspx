<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="MySql.Data.MySqlClient" %>
<%@ Page Language="C#" Debug="true" %>
<html>
  <body>
    <h1><center>Project 4 SL</center></h1>
    <form runat="server">
      <table width="100%" bgcolor="teal">
        <tr>
          <td>
            <asp:Button Text="insert/update/delete record" OnClick="OnAdd"
              RunAt="server" />
          </td>
        </tr>
      </table>
      <br>
      <center>
        <asp:DataGrid ID="MyDataGrid"
          AutoGenerateColumns="false" CellPadding="2"
          BorderWidth="1" BorderColor="lightgray"
          Font-Name="Verdana" Font-Size="8pt"
          GridLines="vertical" Width="90%"
          RunAt="server">
		  
          <Columns>
		    <asp:BoundColumn HeaderText="ID"
              DataField="SLid" />
            <asp:BoundColumn HeaderText="Name"
              DataField="name" />
            <asp:BoundColumn HeaderText="phone"
              DataField="phone" />
			<asp:BoundColumn HeaderText="address"
              DataField="address" />
            <asp:BoundColumn HeaderText="birth date"
              DataField="Dateofbirth" />
            <asp:BoundColumn HeaderText="PA3"
              DataField="Pa3link" />
            <asp:BoundColumn HeaderText="FB"
              DataField="FBlink" />
            <asp:BoundColumn HeaderText="Twitter"
              DataField="Twitterlink" />
          </Columns>
		  
          <HeaderStyle BackColor="teal" ForeColor="white"
            Font-Bold="true" />
          <ItemStyle BackColor="white" ForeColor="darkblue" />
          <AlternatingItemStyle BackColor="beige"
            ForeColor="darkblue" />
        </asp:DataGrid>
    </center>
    </form>
  </body>
</html>

<script language="C#" runat="server">
  void Page_Load (Object sender, EventArgs e)
  {
      if (!IsPostBack) {
          string ConnectString =
              ConfigurationSettings.AppSettings["connectString"];
          MySqlDataAdapter adapter = new MySqlDataAdapter
             ("select * from WP_bro2.SL", ConnectString);
          DataSet ds = new DataSet ();
          adapter.Fill (ds);
          MyDataGrid.DataSource = ds;
          MyDataGrid.DataBind ();
      }
  }

  void OnAdd (Object sender, EventArgs e)
  {
      Response.Redirect ("Sl-addmod.aspx");
  }
</script>
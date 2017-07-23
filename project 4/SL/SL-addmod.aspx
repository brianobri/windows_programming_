<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="MySql.Data.MySqlClient" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Data.SqlClient" %>


<%@ Page Language="C#" Debug="true" %>
<html>
  <body>
    <h1>Insert/update/delete record</h1>
	<p>Directions: fill everything out except ID when creating a new record.  When deleting a record just fill out the record id. When updating a record, fill all textboxes out. </p>
    <form runat="server">
      <table width="100%" bgcolor="teal">
        <tr>
          <td>
            <asp:Button Text="Return to view" OnClick="Onview" RunAt="server" />
          </td>
        </tr>
      </table>
		<asp:Label Text = "ID" Id= "tableID" RunAt="server" />
		<asp:TextBox Id="tbID" RunAt="server" />
		<asp:Label Text = "only used in updating and deleting a record" Id= "unusedID" RunAt="server" />
		<br>
		<asp:Label Text = "Name" Id= "Name" RunAt="server" />
		<asp:TextBox Id="tbName" RunAt="server" />
		<br>
		<asp:Label Text = "Phone" Id= "Phone" RunAt="server" />
		<asp:TextBox Id="tbPhone" RunAt="server" />
		<br>
		<asp:Label Text = "Address" Id= "Address" RunAt="server" />
		<asp:TextBox Id="tbAddress" RunAt="server" />
		<br>
		<asp:Label Text = "Birth date" Id= "Birthdate" RunAt="server" />
		<asp:TextBox Id="tbBirthdate" RunAt="server" />
		<br>
		<asp:Label Text = "PA3 Link" Id= "PA3" RunAt="server" />
		<asp:TextBox Id="tbPA3" RunAt="server" />
		<br>
		<asp:Label Text = "Facebook" Id= "Facebook" RunAt="server" />
		<asp:TextBox Id="tbFacebook" RunAt="server" />
		<br>
		<asp:Label Text = "Twitter" Id= "Twitter" RunAt="server" />
		<asp:TextBox Id="tbTwitter" RunAt="server" />
		<br>
		<asp:Button Text="Insert" OnClick="OnSubmit" RunAt="server" />
		<asp:Button Text="Delete based on id #" OnClick="OnDelete" RunAt="server" />
		<asp:Button Text="Edit based on id #" OnClick="OnEdit" RunAt="server" />
		<br>
		<asp:Label Text="" Id = "testing" RunAt="server" />
    </form>
  </body>
</html>

<script language="C#" runat="server">
void Page_Load (Object sender, EventArgs e)
{

}

public void OnSubmit (Object sender, EventArgs e)
{
	    string ConnectString = ConfigurationSettings.AppSettings["connectString"];
		
		string sqlAdd = "INSERT INTO WP_bro2.SL(Name, phone, address, Dateofbirth, Pa3link, FBlink, Twitterlink)";
        sqlAdd += " Values('" + tbName.Text + "','" + tbPhone.Text + "','" +  tbAddress.Text + "','" + tbBirthdate.Text + "','" +  tbPA3.Text + "','" +  tbFacebook.Text + "','" + tbTwitter.Text + "')";

		MySqlDataAdapter adapter = new MySqlDataAdapter(sqlAdd, ConnectString);
		DataSet ds = new DataSet ();
        adapter.Fill (ds);
	
		Response.Redirect ("SL-bro2.aspx");
}

public void OnDelete (Object sender, EventArgs e)
  {
	    string ConnectString = ConfigurationSettings.AppSettings["connectString"];
		
		string sqlDel = "DELETE FROM WP_bro2.SL WHERE SLid = '" + tbID.Text + "'";
  
		MySqlDataAdapter adapter = new MySqlDataAdapter(sqlDel, ConnectString);
		DataSet ds = new DataSet ();
        adapter.Fill (ds);
	
		Response.Redirect ("SL-bro2.aspx");
  }  
  
public void OnEdit(Object sender, EventArgs e)
{
	    string ConnectString = ConfigurationSettings.AppSettings["connectString"];
		
		string sqlUpd = "UPDATE WP_bro2.SL ";
        sqlUpd += "Set Name = '" + tbName.Text +    "', phone = '"       + tbPhone.Text + "',";
		sqlUpd += " address = '" + tbAddress.Text + "', Dateofbirth = '" + tbBirthdate.Text + "',";
		sqlUpd += " Pa3link = '" + tbPA3.Text +     "', FBlink = '"      + tbFacebook.Text + "', Twitterlink = '" + tbTwitter.Text + "' ";
		sqlUpd += "WHERE SLid = '"+ tbID.Text +"'";
		testing.Text = sqlUpd;
		MySqlDataAdapter adapter = new MySqlDataAdapter(sqlUpd, ConnectString);
		DataSet ds = new DataSet ();
        adapter.Fill (ds);
	
		Response.Redirect ("SL-bro2.aspx");
}   
  
public void Onview (Object sender, EventArgs e)
{
    Response.Redirect ("SL-bro2.aspx");
}
</script>
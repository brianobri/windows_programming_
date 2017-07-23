<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="MySql.Data.MySqlClient" %>
<%@ Page Language="C#" Debug="true" %>

<html>
  <body>
    <h1>Please Log In</h1>
    <hr>
    <form runat="server">
      <table cellpadding="8">
        <tr>
          <td>
            User Name:
          </td>
          <td>
            <asp:TextBox ID="UserName" RunAt="server" />
          </td>
        </tr>
        <tr>	
          <td>
            Password:
          </td>
          <td>
            <asp:TextBox ID="Password" TextMode="password"
              RunAt="server" />
          </td>
        </tr>
        <tr>
          <td>
            <asp:Button Text="Log In" OnClick="OnLogIn"
              RunAt="server" />
          </td>
          <td>
            <asp:CheckBox Text="Keep me signed in" ID="Persistent"
              RunAt="server" />
          </td>
        </tr>
      </table>
    </form>
    <hr>
    <h3><asp:Label ID="Output" RunAt="server" /></h3>
  </body>
</html>

<script language="C#" runat="server">
  void OnLogIn (Object sender, EventArgs e)
  {
      if (CustomAuthenticate (UserName.Text, Password.Text)) {
          string url = FormsAuthentication.GetRedirectUrl
              (UserName.Text, Persistent.Checked);

          FormsAuthentication.SetAuthCookie (UserName.Text,
              Persistent.Checked);

          if (!Persistent.Checked) {
              HttpCookie cookie =
                Response.Cookies[FormsAuthentication.FormsCookieName];
              cookie.Expires = DateTime.Now +
                  new TimeSpan (0, 0, 8, 8);
          }

          Response.Redirect (url);
      }
      else
          Output.Text = "Invalid login";
  }

  bool CustomAuthenticate (string username, string password)
  {
      MySqlConnection connection = new MySqlConnection
          ("server=db1.cs.uakron.edu;database=WP_bro2;uid=bro2;pwd=meeBee3i;allow zero datetime=yes");

      try {
          connection.Open ();

          StringBuilder builder = new StringBuilder ();
          builder.Append ("select count(*) from users " +
              "where username = \'");
          builder.Append (username);
          builder.Append ("\' and pwd = \'"); //don't use keyword password as db collumn name for MySQL
          builder.Append (password);
          builder.Append ("\';");

          MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
		
	 Int64 count = (Int64) command.ExecuteScalar ();
	 return(count > 0);
      }
      catch (MySqlException) {
          return false;
      }
      finally {
          connection.Close ();
      }
  }
</script>
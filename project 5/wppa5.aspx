<html>
  <body>
    <h1>Public Page</h1>
    <hr>
    <form runat="server">
      <asp:Button Text="Social Page" OnClick="OnViewSecret"
        RunAt="server" />
    </form>
  </body>
</html>

<script language="C#" runat="server">
  void OnViewSecret (Object sender, EventArgs e)
  {
      Response.Redirect ("SL/SL-bro2.aspx");
  }
</script>
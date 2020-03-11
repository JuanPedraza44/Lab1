<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Modificar</title>
</head>
<body>
    <form action="/Video/Modificar" method="post">
    <fieldset>
    <legend>Informacion</legend>

    <label for="idvideo">idvideo:</label>
        <input type="text" name="idvideo" />
        <br />

        <label for="nombre">titulo:</label>
        <input type="text" name="nombre" />
        <br />

        <label for="repro">repro:</label>
        <input type="text" name="repro" />
        <br />

        <label for="url">url:</label>
        <input type="text" name="url" />
        <br />
        <input type="submit" name="modificarVideo" value="Modificar video " />
      </fieldset>
      </form>
</body>
</html>

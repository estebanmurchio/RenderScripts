RenderScripts
=============

Renders javacript to the view.

Usage
=====

    var list = HttpContextBase.Items["Scripts"] as IList<string> ?? new List<string>();
    
    list.Add("<script>alert('hi!');</script>");


Simply add `@Html.RenderScripts()` in the view.

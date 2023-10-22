using UnityEditor;
using System.Collections.Generic;
using ScriptBoy.EButtonEditor;

public static class EButtonDrawerExtension
{
    private static Dictionary<Editor, EButtonDrawer> s_Drawers = new Dictionary<Editor, EButtonDrawer>();

    private static EButtonDrawer GetDrawer(Editor editor)
    {
        EButtonDrawer drawer;
        if (!s_Drawers.TryGetValue(editor, out drawer))
        {
            drawer = new EButtonDrawer(editor.target);
            s_Drawers.Add(editor, drawer);
        }
        return drawer;
    }

    public static void DrawEButtons(this Editor editor)
    {
        GetDrawer(editor).Draw();
    }
}

using UnityEngine;
using UnityEditor;

namespace ScriptBoy.EButtonEditor
{
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class MonoBehaviourInspector : Editor
    {
        public EButtonDrawer m_EButtonDrawer;

        public void OnEnable()
        {
            m_EButtonDrawer = new EButtonDrawer(target);
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            m_EButtonDrawer.Draw();
        }
    }
}
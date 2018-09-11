using System.Collections.Generic;

namespace Assets.Editor.IMGUIExtend.UI.Canvas.LayoutCanvas
{
    public class LayoutCanvas:Canvas
    {

        public override void Remove(IGraphic rect)
        {
            var org = m_children;
            m_children = new List<IGraphic>();
            for (var i = 0; i < org.Count; i++)
            {
                if (org[i] != rect)
                {
                    Add(org[i]);
                }
            }
        }
    }
}

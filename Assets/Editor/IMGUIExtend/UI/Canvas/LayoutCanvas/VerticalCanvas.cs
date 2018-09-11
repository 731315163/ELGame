using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.Canvas.LayoutCanvas
{
    /// <summary>
    /// 纵向布局
    /// </summary>
    public class VerticalCanvas:LayoutCanvas
    {
        public override void Add(IGraphic rect)
        {
            Rect r = base.Rect;
            Rect r1 = rect.Rect;
            rect.Rect = new Rect(r.y, r.yMax, r1.width, r1.height);
            base.Add(rect);
        }

        public override void Draw(Rect rect)
        {
            float xpos = rect.x;
            float ypos = rect.y;
            for (var i = 0; i < m_children.Count; i++)
            {
                if (!m_children[i].IsActive)
                {
                    continue;
                }
                Rect r = m_children[i].Rect;
                m_children[i].Draw(new Rect(xpos,ypos,r.width,r.height));
                xpos += r.width;
            }
        }
    }
}

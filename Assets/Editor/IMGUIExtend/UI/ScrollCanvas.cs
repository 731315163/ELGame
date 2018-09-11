using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI
{
    public class ScrollCanvas:Canvas
    {
        public Rect Mask { get; set; }
        public override Rect Rect
        {
            get { return Mask;}
            set { Mask = value; }
        }

        public override T Find<T>(Vector2 pos)
        {
            pos.x += Mask.x;
            pos.y += Mask.y;
            if (Mask.Contains(pos))
            {
                return base.Find<T>(pos);
            }
            return null;
        }
    }
}

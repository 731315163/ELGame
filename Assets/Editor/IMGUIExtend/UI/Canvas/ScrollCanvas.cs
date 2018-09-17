using System.Collections.Generic;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.Canvas
{
    public class ScrollCanvas:Canvas
    {
        public Rect Mask { get; set; }
        public override Rect Rect
        {
            get { return Mask;}
            set { Mask = value; }
        }

        public ScrollCanvas(Rect mask)
        {
            this.Mask = mask;
        }
        public override IEnumerable<IGraphic> Find(Vector2 pos)
        {
            pos.x += Mask.x;
            pos.y += Mask.y;
            if (Mask.Contains(pos))
            {
                return base.Find(pos);
            }
            return null;
        }
    }
}

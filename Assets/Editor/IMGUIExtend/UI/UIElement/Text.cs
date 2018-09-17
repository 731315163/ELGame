using Assets.Editor.IMGUIExtend.UI.Canvas;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.UIElement
{
    public abstract class Text:IGraphic
    {
        public virtual Rect Rect { get; set; }
        public virtual bool IsActive { get; set; }
        public bool IsRaycast { get; set; }
        public  ICanvas Father { get; set; }
        
        public abstract void Draw(Rect rect);

    }
}

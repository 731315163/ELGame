using Assets.Editor.IMGUIExtend.UI.Canvas;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI
{
    public interface IGraphic:IRect
    {
       
        bool IsActive { get; set; }
        ICanvas Father { get; set; }
        void Draw(Rect rect);
    }
}

using Assets.Editor.IMGUIExtend.UI.Canvas;
using UnityEditor;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.UIElement
{
    public class Image : IGraphic
    {
        public Rect Rect { get; set; }
        public Texture texture;
        public float Aspect = 0;
        public ScaleMode ScaleMode = ScaleMode.StretchToFill;
        public bool IsActive { get; set; }
        public bool IsRaycast { get; set; }
        public ICanvas Father { get; set; }


        public Image(Texture texture, Rect rect)
        {
            this.Rect = rect;
            this.texture = texture;
        }
        public void Draw(Rect rect)
        {
            GUI.DrawTexture(new Rect(rect.position, Rect.size), texture, ScaleMode, true, Aspect);
        }


    }

}
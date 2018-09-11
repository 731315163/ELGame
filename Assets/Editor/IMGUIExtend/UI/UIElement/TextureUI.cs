using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.UIElement
{
    public class TextureUI:IGraphic
    {
        public Rect Rect { get; set; }
        public Texture texture;
        public ScaleMode ScaleMode = ScaleMode.StretchToFill;

        public TextureUI(Texture texture,Rect rect)
        {
            this.Rect = rect;
            this.texture = texture;
        }
        public void Draw(Rect rect)
        {
            GUI.DrawTexture(new Rect(rect.position,Rect.size),texture,ScaleMode );
        }

        public bool IsActive { get; set; }
        public ICanvas Father { get; set; }
    }
}

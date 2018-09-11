using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IMGUIExtend;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.UIElement
{
    public enum FontAutoSize
    {
        AutoSize,
        OriginSize,
        PreferreSize
    }
    public class Lable:IGraphic
    {
        
        public Rect Rect {get;set; }
        public bool IsActive { get; set; }
        public ICanvas Father { get; set; }

        protected GUIStyle m_guiStyle;
        public static Font DefaultFont = Font.CreateDynamicFontFromOSFont("Arial",14); 
        public GUIStyle GuiStyle
        {
            get
            {
                return m_guiStyle;
            }
            set
            {
                m_guiStyle = value;
                ReSetRect(Text);
            }
        }

        protected string m_text;
        public string Text
        {
            get { return m_text; }
            set
            {
                m_text = value;
                ReSetRect(m_text);
            }
        }

        public Lable()
        {
            var Style = new GUIStyle();
            Style.font = DefaultFont;
            GuiStyle = Style;
        }
        public Lable(Rect rect, string text = null):this()
        {
            this.Rect = rect;
            this.Text = text;

        }
        public void Draw(Rect rect)
        {
            GUI.Label(new Rect(rect.position,Rect.size), Text, GuiStyle);
        }

        protected void ReSetRect(string s)
        {
            var v = GuiStyle.font.GetFontSize(s, GuiStyle.fontSize, GuiStyle.fontStyle);
            this.Rect = new Rect(this.Rect.position, v);
        }
    }
}

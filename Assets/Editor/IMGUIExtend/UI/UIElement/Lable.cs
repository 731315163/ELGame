using Assets.Editor.IMGUIExtend.UI.Canvas;
using IMGUIExtend;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.UIElement
{

    public class Lable:IGraphic
    {
        
        protected GUIStyle m_guiStyle;
      
        public GUIStyle GUIStyle
        {
            get
            {
                if(m_guiStyle != null)
                    return m_guiStyle;
                return GUI.skin.label;
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

        public Lable(string text)
        {
            this.Text = text;
        }
        public Lable(Rect rect)
        {
            this.Rect = rect;
        }
        public Lable(Rect rect, string text = null)
        {
            this.Rect = rect;
            this.Text = text;
            
        }

        public bool IsActive { get; set; }
        public ICanvas Father { get; set; }

        public  void Draw(Rect rect)
        {
            GUI.Label(new Rect(rect.position,Rect.size), Text, GUIStyle);
        }

        protected void ReSetRect(string s)
        {
            var v = GUIStyle.font.GetFontSize(s, GUIStyle.fontSize, GUIStyle.fontStyle);
            this.Rect = new Rect(this.Rect.position, v);
        }

        public Rect Rect { get; set; }
    }
}

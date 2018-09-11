using System.Collections.Generic;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.Canvas
{
    public  class Canvas:ICanvas
    {

       
        public virtual bool IsActive { get; set; }

        protected List<IGraphic> m_children = new List<IGraphic>();
        public ICanvas Father { get; set; }
        public Canvas()
        {
            IsActive = true;
        }
       
        protected Rect m_rect;
        public virtual Rect Rect
        {
            get
            {
                float wmax = 0;
                float hmax = 0;
                for (var i = 0; i < m_children.Count; i++)
                {
                    if (!m_children[i].IsActive)
                        continue;
                    wmax = wmax > m_children[i].Rect.xMax ? wmax : m_children[i].Rect.xMax;
                    hmax = hmax > m_children[i].Rect.yMax ? hmax : m_children[i].Rect.yMax;
                }
                return new Rect(m_rect.x, m_rect.y, wmax, hmax);
            }
            set
            {
                m_rect = value;
            }
        }
        public virtual void Draw(Rect rect)
        {
            for (var i = 0; i < m_children.Count; i++)
            {
                m_children[i].Draw(m_children[i].Rect);
            }
            
        }
       
        public virtual T Find<T>(Vector2 pos) where T : class, IGraphic
        {
            for (var i = 0; i < m_children.Count; i++)
            {
                if (m_children[i].IsActive && m_children[i].Rect.Contains(pos))
                {
                    var canvas = m_children[i] as ICanvas;
                    if (canvas != null)
                        return canvas.Find<T>(pos);
                    return m_children[i] as T;
                }
            }
            return default(T);
        }

      

        public virtual void Add(IGraphic rect)
        {
            rect.Father = this;
            m_children.Add(rect);
        }

        public virtual void Remove(IGraphic rect)
        {
            m_children.Remove(rect);
        }

        public int Index(IGraphic item)
        {
            return m_children.IndexOf(item);
        }

        public void Insert(int index, IGraphic item)
        {
           m_children.Insert(index,item);
        }

        public virtual void Clear()
        {
            m_children.Clear();
        }
    }
}

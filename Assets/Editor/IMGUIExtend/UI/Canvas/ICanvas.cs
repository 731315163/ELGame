using System.Collections.Generic;
using UnityEngine;

namespace Assets.Editor.IMGUIExtend.UI.Canvas
{
    public interface ICanvas:IGraphic
    {

        IEnumerable< IGraphic> Find(Vector2 pos);
        
        void Add(IGraphic item);
        void Remove(IGraphic item);

        int Index(IGraphic item);

        void Insert(int index, IGraphic item);
        void Clear();

    }
}

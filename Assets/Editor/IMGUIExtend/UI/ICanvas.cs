using System;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Editor.IMGUIExtend.UI
{
    public interface ICanvas:IGraphic
    {
        /// <summary>
        /// 查找UI
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pos"></param>
        /// <returns></returns>
        T Find<T>(Vector2 pos) where T :class ,IGraphic;
        /// <summary>
        /// 更新UI
        /// </summary>
        void Update();
        
        void Add(IGraphic item);
        void Remove(IGraphic item);

        int Index(IGraphic item);

        void Insert(int index, IGraphic item);
        void Clear();

    }
}

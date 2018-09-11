using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;


public class Button
{
    public event Action Click;
    
    public void Draw(Rect rect,string s)
    {
        
        if (GUI.Button(rect,s) && Click != null)
        {
            Click.Invoke();
        }
    }

    public void Draw(Rect rect, Texture tex)
    {
        if (GUI.Button(rect, tex) && Click != null)
        {
            Click.Invoke();
        }
    }

    public virtual void Draw(){}
}
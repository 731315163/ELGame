using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class TextureButton : Button
{
    protected Texture texure;
    protected Rect rect;
    public TextureButton(Texture texure, Rect rect)
    {
        this.texure = texure;
        this.rect = rect;
    }

    public override void Draw()
    {
        base.Draw(rect,texure);
    }
}
using UnityEngine;

public class StringButton:Button
{
    protected string name;
    public Rect Rect;

    public StringButton(string name, Rect rect)
    {
        this.name = name;
        this.Rect = rect;
    }

    public override void Draw()
    {
        base.Draw(Rect,name);
    }
}
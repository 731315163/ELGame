using SubjectNerd.PsdImporter.PsdParser;
using UnityEditor;
using UnityEngine;


public class PSDLayerButton : StringButton
{
    public IPsdLayer Layer;
    protected PSDLayerButton[] ChildrenButton;
    public bool Active = true;
    public PSDLayerButton(IPsdLayer layer, Rect rect) : base("", rect)
    {
        this.Layer = layer;
        ChildrenButton = new PSDLayerButton[layer.Childs.Length];
        for (int i = 0; i < ChildrenButton.Length; ++i)
        {
            ChildrenButton[i] = new PSDLayerButton(Layer.Childs[i],new Rect(0,0,100,100));
        }
    }
  

    public override void Draw()
    {
        base.Draw();
        GUIContent v = new GUIContent();
        EditorGUI.Foldout(Rect, Active, Layer.Name);
    }
}

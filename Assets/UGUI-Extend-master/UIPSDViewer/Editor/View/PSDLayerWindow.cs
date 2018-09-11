using System;
using System.Collections.Generic;
using SubjectNerd.PsdImporter.PsdParser;
using UnityEditor;
using UnityEngine;


public class PSDLayerWindow
{
    protected PSDLayerButton rootpsdbutton;
    public IPsdLayer RootPSDLayer;

    public PSDLayerWindow()
    {
        rootpsdbutton = new PSDLayerButton(RootPSDLayer,new Rect(0,0,100,100));
    }
    public void Draw()
    {
        EditorGUILayout.BeginScrollView(new Vector2(0, 0));
        rootpsdbutton.Draw();
        EditorGUILayout.EndScrollView();
    }

}

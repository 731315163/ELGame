using SubjectNerd.PsdImporter.PsdParser;
using UnityEngine;
using UnityEditor;

public class PSDParser
{

    public static PsdDocument LoadPsdDocument(Object asset)
    {
        if (asset != null)
        {
            string path = UnityEditor.AssetDatabase.GetAssetPath(asset);
            if (path.EndsWith(".psd"))
                return PsdDocument.Create(path);
        }

        return null;
    }
}
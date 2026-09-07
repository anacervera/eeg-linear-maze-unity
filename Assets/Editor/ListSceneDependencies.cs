using UnityEngine;
using UnityEditor;
using System.Linq;

public class ListSceneDependencies
{
    [MenuItem("Tools/List Scene Dependencies")]
    static void ListDependencies()
    {
        string[] scenes =
        {
            "Assets/Scenes/LinearMaze.unity",
            "Assets/Scenes/Recognition test.unity"
        };

        foreach (string scene in scenes)
        {
            Debug.Log("\n========== " + scene + " ==========");

            string[] dependencies =
                AssetDatabase.GetDependencies(scene, true)
                .OrderBy(x => x)
                .ToArray();

            foreach (string dependency in dependencies)
                Debug.Log(dependency);
        }
    }
}
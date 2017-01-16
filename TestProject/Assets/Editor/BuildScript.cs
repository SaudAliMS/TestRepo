using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Linq;

public class BuildScript
{
	static string TARGET_DIR = "/Users/Shared/Jenkins/Desktop/Builds/";

    static void PerformAndroidBuild()
    {
		BuildPipeline.BuildPlayer(GetScenes(), TARGET_DIR+"android.apk", BuildTarget.Android, BuildOptions.None);
    }

    static string[] GetScenes()
    {
        return EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
    }
}
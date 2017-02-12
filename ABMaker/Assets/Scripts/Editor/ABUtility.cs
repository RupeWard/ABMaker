using UnityEngine;
using System.Collections;
using UnityEditor;

public class ABUtility
{
	[MenuItem( "ABTest/Build ALL" )]
	static void BuildAll( )
	{
		BuildPipeline.BuildAssetBundles(
			"Assets/AssetBundles",
			BuildAssetBundleOptions.None,
			BuildTarget.StandaloneWindows64
			);
	}
}

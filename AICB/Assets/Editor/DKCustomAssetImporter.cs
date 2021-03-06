﻿using UnityEngine;
using UnityEditor;

class DKCustomAssetImporter : AssetPostprocessor
{
	static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		Debug.Log(importedAssets);
		foreach (string str in importedAssets)
			{
				Debug.Log("Reimported Asset: " + str);
			}
		foreach (string str in deletedAssets)
			{
				Debug.Log("Deleted Asset: " + str);
			}

		for (int i = 0; i < movedAssets.Length; i++)
			{
				Debug.Log("Moved Asset: " + movedAssets [i] + " from: " + movedFromAssetPaths [i]);
			}
	}
}
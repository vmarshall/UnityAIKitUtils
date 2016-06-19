using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System;

/// Store this code as "MakeFolders.cs" in the Assets\Editor directory (create it, if it does not exist)
/// Creates a number of directories for storage of various content types.
/// Modify as you see fit.
/// Directories are created in the Assets dir.
/// Not tested on a Mac.

 // CHANGE
 
public class DKBuildProjectDirectories : ScriptableObject
{
	String topDir = "DK_DEBUG/";

	[MenuItem("DK/BuildProjectDirectories")]
	static void MenuMakeFolders()
	{
		CreateFolders();
	}

	static void CreateFolders()
	{
		string f = Application.dataPath + "/DK_DEBUG/";


		Directory.CreateDirectory(f + "Meshes");
		Directory.CreateDirectory(f + "Fonts");
		Directory.CreateDirectory(f + "Plugins");
		Directory.CreateDirectory(f + "Textures");
		Directory.CreateDirectory(f + "Materials");
		Directory.CreateDirectory(f + "Physics");
		Directory.CreateDirectory(f + "Resources");
		Directory.CreateDirectory(f + "Scenes");
		Directory.CreateDirectory(f + "Music");
		Directory.CreateDirectory(f + "Packages");
		Directory.CreateDirectory(f + "Scripts");
		Directory.CreateDirectory(f + "Shaders");
		Directory.CreateDirectory(f + "Sounds");

		Debug.Log("Created directories");
	}
}

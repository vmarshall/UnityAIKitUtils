﻿// SceneDumper.cs
//
// History:
// version 1.0 - December 2010 - Yossarian King
 
using StreamWriter = System.IO.StreamWriter;
 
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System;

public static class DKSceneDumper
{
	[MenuItem("DK/Debug/DumpScene")]
	public static void DumpScene()
	{
//		string f = Application.dataPath + "Assets/DK_DEBUG/";
//
//
//		Directory.CreateDirectory(f + "DUMPED_SCENES");
		if ((Selection.gameObjects == null) || (Selection.gameObjects.Length == 0))
			{
				Debug.LogError("Please select the object(s) you wish to dump.");
				return;
			}
 
		// string filename = @"C:\unity-scene.txt";

		// TODO Clean Up bloody paths

		string filename = "Assets/Scratch/dumped-scene.txt";

		Debug.Log("Dumping scene to " + filename + " ...");
		using (StreamWriter writer = new StreamWriter(filename, false))
			{
				foreach (GameObject gameObject in Selection.gameObjects)
					{
						DumpGameObject(gameObject, writer, "");
					}
			}
		Debug.Log("Scene dumped to " + filename);
	}

	private static void DumpGameObject(GameObject gameObject, StreamWriter writer, string indent)
	{
		writer.WriteLine("{0}+{1}", indent, gameObject.name);
 
		foreach (Component component in gameObject.GetComponents<Component>())
			{
				DumpComponent(component, writer, indent + "  ");
			}
 
		foreach (Transform child in gameObject.transform)
			{
				DumpGameObject(child.gameObject, writer, indent + "  ");
			}
	}

	private static void DumpComponent(Component component, StreamWriter writer, string indent)
	{
		writer.WriteLine("{0}{1}", indent, (component == null ? "(null)" : component.GetType().Name));
	}
}
﻿using System.Linq;
using UnityEngine;
using UnityEditor;

namespace UnityQuickSheet
{
    /// <summary>
    /// Abstract class for making reload-proof singletons out of ScriptableObjects
    /// Returns the asset created on editor, null if there is none
    /// Based on https://www.youtube.com/watch?v=VBA1QCoEAX4
    /// 
    /// See Also:
    ///     blog page: http://baraujo.net/unity3d-making-singletons-from-scriptableobjects-automatically/
    ///     gist page: https://gist.github.com/baraujo/07bb162a1f916595cad1a2d1fee5e72d
    /// </summary>
    /// <typeparam name="T">Type of the singleton</typeparam>

    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        static T _instance = null;
        public static T Instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
                }
                if (!_instance)
                {
                    if (typeof(T) == typeof(GoogleDataSettings))
                    {
                        _instance = AssetDatabase.LoadAssetAtPath<T>(@"Assets/QuickSheet/GDataPlugin/Editor/Google Data Settings.asset");
                    }
                    else if (typeof(T) == typeof(ExcelSettings))
                    {
                        _instance = AssetDatabase.LoadAssetAtPath<T>(@"Assets/QuickSheet/ExcelPlugin/Editor/Excel Settings.asset");
                    }
                }
                if (!_instance)
                {
                    Debug.LogWarning("No instance of " + typeof(T).Name + " is loaded. Please create or remport a " + typeof(T).Name + " asset file.");
                }
                return _instance;
            }
        }
    }
}

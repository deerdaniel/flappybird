﻿using UnityEngine;

namespace _Project.Scripts.Singleton
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T _instance;
    
        public static T instance => GetInstance();
    
        private static T GetInstance()
        {
            if (_instance == null) FindInstance();
            return _instance;
        }
    
        private static void FindInstance()
        {
            var singleton = FindObjectOfType<T>();
    
            if (singleton == null)
                Debug.LogError($"No Object With Script: {nameof(T)}");
            else
                _instance = singleton;
        }
    }
}
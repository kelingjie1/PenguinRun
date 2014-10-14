using UnityEngine;
using System.Collections;

public class ResourceManager
{
    public static GameObject Load(string name)
    {
        GameObject obj= Resources.Load(name) as GameObject;
        return GameObject.Instantiate(obj) as GameObject;
    }
}

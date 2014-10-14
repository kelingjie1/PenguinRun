using UnityEngine;
using System.Collections;

public static class MonoBehaviourExtension
{
    public static GameObject FindChild(this GameObject obj, string name)
    {
        return Util.FindChild(name, obj);
    }
}

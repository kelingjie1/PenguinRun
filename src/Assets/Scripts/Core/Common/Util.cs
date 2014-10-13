using UnityEngine;
using System.Collections;

public class Util 
{
    public static Transform FindTransform(string name,Transform tran)
    {
        for (int i = 0; i < tran.childCount; i++)
        {
            Transform t = tran.GetChild(i);
            if (t.name.Equals(name))
            {
                return tran;
            }
        }
        return null;
    }
    public static GameObject FindChild(string name,GameObject obj)
    {
        Transform t=FindTransform(name,obj.transform);
        if (!t)
	    {
		    return null; 
	    }
        return t.gameObject;
    }
}

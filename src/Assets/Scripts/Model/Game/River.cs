using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class River : MonoBehaviour 
{
    public static River Instance;
    public int passLineCount;
    public List<RiverLine> riverLines = new List<RiverLine>();

    public void CreateMap()
    {
        for (int i = 0; i < 11; i++)
        {
            riverLines.Add(RiverLine.CreateNewLine());
        }
    }
    void Awake()
    {
        Instance = this;
    }
}

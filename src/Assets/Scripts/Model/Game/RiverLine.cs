using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RiverLine
{
    public int id;
    public List<IceBlock> iceBlocks = new List<IceBlock>();
    public int roadId;
    public static RiverLine CreateNewLine()
    {
        RiverLine line = new RiverLine();
        line.id = River.Instance.riverLines.Count + River.Instance.passLineCount;
        
        if (GameController.Instance.gameType==GameType.Tap)
        {
            for (int i = 0; i < 5; i++)
            {
                IceBlock iceblock= Resources.Load<GameObject>("Prefab/Game/IceBlock").Instantiate().GetComponent<IceBlock>();
                River.Instance.gameObject.AddChild(iceblock.gameObject);
                iceblock.transform.localPosition = new Vector3(-200 + i * 100, line.id * 100, 0);
                line.iceBlocks.Add(iceblock);
            }
        }
        else
        {
            Debug.LogError("GameTypeError");
        }
        return line;
    }
}

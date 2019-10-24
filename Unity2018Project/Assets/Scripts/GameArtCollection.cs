using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;


    public void AddData(GameArtData obj)
    {
        foreach (var gameArt in collectionList)
        {
            Debug.Log(gameArt);
        }

    }
/*    public void AddData(GameArtData obj)
    {
    if (!collectionList.Contains(obj))
        {
            collectionList.Add(obj);
        }
    }*/
    
    /*public void AddData(GameArtData obj)
    {if (!obj.collected)
        {
         collectionList.Add(obj);
         obj.collected = true;
        }
    }*/

    public void RemoveLastItem()
    {
        collectionList.RemoveAt( index: collectionList.Count-1);
    }
    
}

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

    public void RemoveLastItem()
    {
        collectionList.RemoveAt( index: collectionList.Count-1);
    }
    
}

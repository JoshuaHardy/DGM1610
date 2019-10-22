using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class PlayerData : GameArtData
{
   public UnityAction<GameObject> instanceAction;
   
   
   public FloatDataScript health;
   public List<WeaponData> weapons;
   public ClothesData shirt;
   public ClothesData pants;

   
   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);
      var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      playerSprite.sprite = sprite;
      playerSprite.color = spriteColor;
      instanceAction(newPlayer);
   }


   
}

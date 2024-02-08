using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class PrizeScript : MonoBehaviour
{ 
   void OnCollisionEnter2D(Collision2D col)
   {
      //score goes up by one
      GameManager.Instance.score++;
      //prize relocates to random new position
      transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10));

   }
}

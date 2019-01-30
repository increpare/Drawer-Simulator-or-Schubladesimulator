using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLOORSCRIPT : MonoBehaviour
{
   public GameObject victorytext;
   void OnTriggerEnter(Collider other)
    {
        if(other.name=="Schublade"){
            victorytext.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatDengue : MonoBehaviour
{
      private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player") )
       {
        Debug.Log("Picado!!!");
         other.GetComponent<PlayerStatus>().ReceberDano(2);
       }
    }
}

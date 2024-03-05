using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonCombat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dengue")) 
        {
            Debug.Log("Matou A dengue");
        }
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Você foi Picado!!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerfSpawnDengue : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Criadouro")) 
        {
            Debug.Log("Você acabou com o spwan da dengue!!");
        }
    }
}

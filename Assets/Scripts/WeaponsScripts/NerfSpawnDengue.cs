using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerfSpawnDengue : MonoBehaviour
{
    public GameObject aguaParada;
    public GameObject aguaDengue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Criadouro")) 
        {
            Debug.Log("Parabens vc conseguiu nerfar o spawn");
            other.GetComponent<Spawner>().enabledSpawn = false;
           aguaParada.SetActive(true);
           aguaDengue.SetActive(false);
        }
    }
}

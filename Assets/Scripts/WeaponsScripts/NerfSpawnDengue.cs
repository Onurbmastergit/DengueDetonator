using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerfSpawnDengue : MonoBehaviour
{
    public GameObject aguaParada;
    public GameObject aguaDengue;

    public GameObject manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Criadouro")) 
        {
            Debug.Log("Parabens vc conseguiu nerfar o spawn");
            other.GetComponent<Spawner>().enabledSpawn = false;
           aguaParada.SetActive(true);
           aguaDengue.SetActive(false);
            if (manager.GetComponent<AnimationScript>().enabledHand == false && manager.GetComponent<AnimationScript>().numHands == 2)
            {
                manager.GetComponent<AnimationScript>().sandLimit--;
            }
        }
    }
}

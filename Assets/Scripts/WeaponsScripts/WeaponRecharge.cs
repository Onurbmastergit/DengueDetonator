using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRecharge : MonoBehaviour
{
    public bool spray;
    public bool areia;
    public bool repelente;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && spray == true) 
        {
            other.GetComponent<AnimationScript>().sprayLimit+= 2;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player") && areia == true)
        {
            other.GetComponent<AnimationScript>().sandLimit+= 2;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player") && repelente == true)
        {
            other.GetComponent<PlayerStatus>().vidaAtual++;
            Destroy(gameObject);
        }
    }
}

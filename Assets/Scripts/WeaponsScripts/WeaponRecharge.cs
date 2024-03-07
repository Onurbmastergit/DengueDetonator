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
            if (other.GetComponent<AnimationScript>().sprayLimit < 0)
            {
                other.GetComponent<AnimationScript>().sprayLimit += 2;
            }
            other.GetComponent<AnimationScript>().sprayLimit++;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player") && areia == true)
        {
            if (other.GetComponent<AnimationScript>().sandLimit  < 0) 
            {
                other.GetComponent<AnimationScript>().sandLimit +=2;
            }
            other.GetComponent<AnimationScript>().sandLimit++;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player") && repelente == true)
        {

            other.GetComponent<PlayerStatus>().vidaAtual++;
            Destroy(gameObject);
        }
    }
}

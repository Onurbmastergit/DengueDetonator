using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject handAerosol;
    public GameObject handAerosol2;
    public GameObject handSand;
    public GameObject handSand2;
    public GameObject handRaquete;
    public GameObject handRaquete1;

    public Animator handAnimator;
    public AudioSource sprayAerosol;

    public  int sprayLimit = 4;
    public  int sandLimit = 5;

    int numHands;
    bool enabledHand = true;

    void Start()
    {
        
        numHands = 1;
        handAerosol.SetActive(enabledHand);
        handAerosol2.SetActive(!enabledHand);
    }

    void Update()
    {
        if (numHands == 1 && sprayLimit != 0)
        {
            handAnimator.SetBool("Aerosol" , true);
            handAnimator.SetBool("Raquete", false);
            handAnimator.SetBool("Sand", false);
            handSand.SetActive(false);
            handSand2.SetActive(false);
            handRaquete.SetActive(false);
            handRaquete1.SetActive(false);
            handAerosol.SetActive(enabledHand);
            handAerosol2.SetActive(!enabledHand);
            if (enabledHand == false)
            {
                Invoke("EnalbedHand", 0.3f);
            }
        }
        if (numHands == 2 && sandLimit != 0)
        {
            handAnimator.SetBool("Aerosol", false);
            handAnimator.SetBool("Raquete", false);
            handAnimator.SetBool("Sand", true);
            handAerosol.SetActive(false);
            handAerosol2.SetActive(false);
            handRaquete.SetActive(false);
            handRaquete1.SetActive(false);
            handSand.SetActive(enabledHand);
            handSand2.SetActive(!enabledHand);
            if (enabledHand == false)
            {
                Invoke("EnalbedHand", 0.3f);
            }
        }
        if(numHands == 3)
        {
            handAnimator.SetBool("Aerosol", false);
            handAnimator.SetBool("Sand", false);
            handAnimator.SetBool("Raquete", true);
            handAerosol.SetActive(false);
            handAerosol2.SetActive(false);
            handSand.SetActive(false);
            handSand2.SetActive(false);
            handRaquete.SetActive(enabledHand);
            handRaquete1.SetActive(!enabledHand);
            if (enabledHand == false)
            {
                Invoke("EnalbedHand", 0.3f);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            numHands = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            numHands = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            numHands = 3;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1)) 
        {
            HandAnimation();
        }
        if (sprayLimit <= 0) 
        {    
            sprayLimit = 0;
        }
        if (sandLimit <= 0) 
        {
            sandLimit = 0;
        }

        if (numHands == 1 && sprayLimit == 0) 
        {
            numHands = 3;
        }
        if (numHands == 2 && sandLimit == 0) 
        {
            numHands = 3;
        }

    }

    void HandAnimation() 
    {
        enabledHand = !enabledHand;
        if (numHands == 1 && sprayLimit != 0)
        {
            handAerosol.SetActive(enabledHand);
            handAerosol2.SetActive(!enabledHand);
            if (enabledHand == false && numHands == 1)
            {
                sprayLimit--;
            }
        }
        if (numHands == 2 && sprayLimit != 0)
        {   
            handSand.SetActive(enabledHand);
            handSand2.SetActive(!enabledHand);
            if (enabledHand == false && numHands == 2)
            {
                sandLimit--;
            }
        }
        if(numHands == 3)
        {
           handRaquete.SetActive(enabledHand);
           handRaquete1.SetActive(!enabledHand);
        }
       
       
    }
    void EnalbedHand() 
    {
        enabledHand = true;
        
    }
   
}

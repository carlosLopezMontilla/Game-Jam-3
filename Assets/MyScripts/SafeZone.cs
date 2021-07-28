using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameManager gameManager;
    public bool inSafeZone = false;
    public AudioListener audioListener;

    private void OnTriggerStay(Collider other)
    {
        gameManager.currentValue -= Time.deltaTime* 2 ;
        inSafeZone = true;
        audioListener.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        inSafeZone = false;
        audioListener.enabled = false;
    }
    private void Update()
    {
        if(!inSafeZone)
        {
            audioListener.enabled = true;
        }
    }
}

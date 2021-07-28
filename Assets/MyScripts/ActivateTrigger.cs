using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrigger : MonoBehaviour
{
    public GameObject safeZone;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject, 0f);
        safeZone.SetActive(true);
        
    }
}

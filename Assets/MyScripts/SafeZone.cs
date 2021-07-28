using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerStay(Collider other)
    {
        gameManager.currentValue -= Time.deltaTime* 2 ;
    }
}

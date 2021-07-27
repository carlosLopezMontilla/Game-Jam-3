using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporters : MonoBehaviour
{
    public Transform teleport;

    public GameObject cam1, cam2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.position = teleport.position;
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}

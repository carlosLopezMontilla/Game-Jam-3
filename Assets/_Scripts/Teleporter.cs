using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleport;
    public GameObject cam1, cam2;

    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.CompareTag("Player"))
        {
            other.transform.position = teleport.position;
            cam1.SetActive(false);
            cam2.SetActive(true);

        }
    }
}

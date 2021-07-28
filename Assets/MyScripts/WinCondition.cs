using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject end;

    private void OnTriggerEnter(Collider other)
    {
        end.SetActive(true);
    }
}

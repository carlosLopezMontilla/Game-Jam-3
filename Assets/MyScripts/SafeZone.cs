using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameManager gameManager;
    public bool inSafeZone = false;
    //public AudioListener audioListener;
    public AudioController audioController;

    private void OnTriggerStay(Collider other)
    {
        gameManager.currentValue -= Time.deltaTime * 2;
        inSafeZone = true;
        //audioListener.enabled = false;
        audioController.test[0].volume = 0;
        audioController.test[1].volume = 0;
        audioController.test[2].volume = 0;
        audioController.test[3].volume = 0;
        audioController.test[4].volume = 0;
        audioController.test[5].volume = 0;
        audioController.test[6].volume = 0;
        audioController.test[7].volume = 0;
        audioController.test[8].volume = 0;
        audioController.test[9].volume = 0;
        audioController.test[10].volume = 0;
        audioController.test[11].volume = 0;
        audioController.test[12].volume = 0;
        audioController.test[13].volume = 0;
        audioController.test[14].volume = 0;
        audioController.test[15].volume = 0;
        audioController.test[16].volume = 0;
        audioController.test[17].volume = 0;
        audioController.test[18].volume = 0;
        audioController.test[19].volume = 0;
        audioController.test[20].volume = 0;
        audioController.test[21].volume = 0;
        audioController.test[22].volume = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        inSafeZone = false;
        //audioListener.enabled = false;
        Destroy(this.gameObject, 2f);
        audioController.test[0].volume = 1;
        audioController.test[1].volume = 1;
        audioController.test[2].volume = 1;
        audioController.test[3].volume = 1;
        audioController.test[4].volume = 1;
        audioController.test[5].volume = 1;
        audioController.test[6].volume = 1;
        audioController.test[7].volume = 1;
        audioController.test[8].volume = 1;
        audioController.test[9].volume = 1;
        audioController.test[10].volume = 1;
        audioController.test[11].volume = 1;
        audioController.test[12].volume = 1;
        audioController.test[13].volume = 1;
        audioController.test[14].volume = 1;
        audioController.test[15].volume = 1;
        audioController.test[16].volume = 1;
        audioController.test[17].volume = 1;
        audioController.test[18].volume = 1;
        audioController.test[19].volume = 1;
        audioController.test[20].volume = 1;
        audioController.test[21].volume = 1;
        audioController.test[22].volume = 1;
    }
}

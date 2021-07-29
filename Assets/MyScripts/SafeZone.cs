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
        gameManager.currentValue -= Time.deltaTime * 8;
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
        audioController.test[23].volume = 0;
        audioController.test[24].volume = 0;
        audioController.test[25].volume = 0;
        audioController.test[26].volume = 0;
        audioController.test[27].volume = 0;
        audioController.test[28].volume = 0;
        audioController.test[29].volume = 0;
        audioController.test[30].volume = 0;
        audioController.test[31].volume = 0;
        audioController.test[32].volume = 0;
        audioController.test[33].volume = 0;
        audioController.test[34].volume = 0;
        audioController.test[35].volume = 0;
        audioController.test[36].volume = 0;
        audioController.test[37].volume = 0;
        audioController.test[38].volume = 0;
        audioController.test[39].volume = 0;
        audioController.test[40].volume = 0;
        audioController.test[41].volume = 0;
        audioController.test[42].volume = 0;
        audioController.test[43].volume = 0;
        audioController.test[44].volume = 0;
        audioController.test[45].volume = 0;
        audioController.test[46].volume = 0;
        audioController.test[47].volume = 0;
        audioController.test[48].volume = 0;
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
        audioController.test[23].volume = 1;
        audioController.test[24].volume = 1;
        audioController.test[25].volume = 1;
        audioController.test[26].volume = 1;
        audioController.test[27].volume = 1;
        audioController.test[28].volume = 1;
        audioController.test[29].volume = 1;
        audioController.test[30].volume = 1;
        audioController.test[31].volume = 1;
        audioController.test[32].volume = 1;
        audioController.test[33].volume = 1;
        audioController.test[34].volume = 1;
        audioController.test[35].volume = 1;
        audioController.test[36].volume = 1;
        audioController.test[37].volume = 1;
        audioController.test[38].volume = 1;
        audioController.test[39].volume = 1;
        audioController.test[40].volume = 1;
        audioController.test[41].volume = 1;
        audioController.test[42].volume = 1;
        audioController.test[43].volume = 1;
        audioController.test[44].volume = 1;
        audioController.test[45].volume = 1;
        audioController.test[46].volume = 1;
        audioController.test[47].volume = 1;
        audioController.test[48].volume = 1;
    }
}

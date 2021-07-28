using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Slider slider;
    public float minValue, maxValue, currentValue;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        minValue = 0;
        currentValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentValue += Time.deltaTime;
        slider.maxValue = maxValue;
        slider.value = currentValue;
        if(currentValue >= maxValue)
        {
            deathScreen.SetActive(true);
        }
        if(currentValue <= minValue)
        {
            currentValue = minValue;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        deathScreen.SetActive(false);
    }
}

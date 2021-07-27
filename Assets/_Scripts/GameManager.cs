using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider slider;
    public float minValue, maxValue, currentValue;
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

        slider.value = currentValue;
    }
}

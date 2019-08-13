using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISliderManager : MonoBehaviour{
    // Start is called before the first frame update
    public Text text_value;

    private static int value = 0;
    private Slider bar;
    void Start(){
        bar = GetComponent<Slider>();
        value = (int)bar.value;
    }

    // Update is called once per frame
    void Update(){
        value = (int)bar.value;
        text_value.text = value + " %";
    }
}

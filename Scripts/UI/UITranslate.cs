using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITranslate : MonoBehaviour{
    // Start is called before the first frame update

    private Slider bar;
    private string[] text_Data = {"게임리소스를 받는 중입니다...","압축을 푸는 중입니다...","최적화 중입니다..."};
    private float dulation;
    [SerializeField]public Text number;
    [SerializeField]public Text text;

    void Start(){
        bar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update(){
        bar.value = Mathf.MoveTowards(bar.value, 100.0f, 0.03f);
        int value = (int)bar.value;
        number.text = value + " %";
        if(value < 30){
            text.text = text_Data[0];
        }else if(value < 60){
            text.text = text_Data[1];
        }else{
            text.text = text_Data[2];
        }
        if(value == 100){
            SceneManager.LoadScene("MainScene");
        }
    }
}

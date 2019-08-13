using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITextEvent : MonoBehaviour{

    // Start is called before the first frame update
    public FadeController controller;
    private string[] SceneManager = {"GameScene", "ConfigScene", "MainScene"};

    [SerializeField]public GameObject active;
    [SerializeField]public GameObject disable;

    private bool activeFlag = true;
    void Start(){
       //controller = new FadeController();
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    

    IEnumerator FadeScene(string SceneName){
        controller.FadeOut(0.7f);
        yield return new WaitForSeconds(3f);
        controller.FadeIn(0.6f, ()=>{
            Debug.Log("dydydoido");
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
        });
    }

    public void OnClickEvent_SettingButton(){
        if(activeFlag){
            active.SetActive(true);
            disable.SetActive(false);
            activeFlag = false;
        }else{
            disable.SetActive(true);
            active.SetActive(false);
            activeFlag = true;
        }
    }

    public void OnClickEvent_Game(){
        //StartCoroutine(FadeScene(SceneManager[0]));
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager[0]);
    }

    public void OnClickEvent_Config(){
        //StartCoroutine(FadeScene(SceneManager[1]));
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager[1]);
    }

    public void OnClickEvent_Submit(){
        //StartCoroutine(FadeScene(SceneManager[2]));
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager[2]);
    }

    public void OnClickEvent_Cancle(){
        //StartCoroutine(FadeScene(SceneManager[2]));
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager[2]);
    }

}

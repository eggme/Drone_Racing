using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OobstacleController : MonoBehaviour{
    // Start is called before the first frame update
    [SerializeField] GameObject UI;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        RaycastHit hit;
        Debug.DrawRay(transform.position , transform.forward * 20, Color.blue, 1f);
        if(Physics.Raycast(transform.position , transform.forward ,out hit, 20)){
            Debug.Log(hit.transform.name);
            UI.SetActive(true);
        }
    }
}

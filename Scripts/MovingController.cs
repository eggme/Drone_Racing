using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingController : MonoBehaviour
{
    private float applySpeed;
    float currentAngleX;
    float currentAngleY;
    private Transform transform;
    private Transform tf_Cam;

    private DroneData droneData;

    public MovingController(Transform transform, Transform tf_Cam, DroneData droneData){
        this.transform = transform;
        this.tf_Cam = tf_Cam;
        this.droneData = droneData;
    }

    public void FieldMoving(){
        if(Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0){
            Debug.Log("gdgd Field Moving");
            Vector3 t_Dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical")).normalized;
            
            if(Input.GetKey(KeyCode.LeftShift)){
                applySpeed = droneData.getRunSpeed();
            }else{
                applySpeed = droneData.getWalkSpped();
            }

            transform.Translate(t_Dir * applySpeed * Time.deltaTime, Space.Self);
        }
    }

    public void FieldLooking(){
        if(Input.GetAxisRaw("Mouse Y") != 0){
            float t_AngleX = Input.GetAxisRaw("Mouse Y");
            currentAngleX -= t_AngleX;
            currentAngleX = Mathf.Clamp(currentAngleX, -droneData.getFieldLookLimitX(), droneData.getFieldLookLimitX());
            tf_Cam.localEulerAngles = new Vector3(currentAngleX, 0, 0);
        }
        if(Input.GetAxisRaw("Mouse X") != 0){
            float t_AngleY = Input.GetAxisRaw("Mouse X");
            Vector3 t_Rot = new Vector3(0, t_AngleY * droneData.getFieldSensitivity(), 0);
            transform.rotation = Quaternion.Euler(transform.localEulerAngles + t_Rot);
        }
    }
}

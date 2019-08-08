using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneContoller : MonoBehaviour{
    // Start is called before the first frame update
    [SerializeField] Transform tf_Cam;
    [SerializeField] float runSpeed;
    [SerializeField] float walkSpped;
    [SerializeField] float fieldLookLimitX;
    [SerializeField] float fieldSensitivity;
    CharacterController characterController;
    Animator animator;
    private MovingController mc;
    private Rigidbody rigidbody;

    private Animator anim;
    private CapsuleCollider col;
    void Start(){
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        DroneData droneData = new DroneData(runSpeed, walkSpped, fieldLookLimitX, fieldSensitivity);
        mc = new MovingController(GetComponent<Transform>(), tf_Cam, droneData);
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator> ();
        col = GetComponent<CapsuleCollider> ();
    }

    // Update is called once per frame
    void Update(){
        
    }
}

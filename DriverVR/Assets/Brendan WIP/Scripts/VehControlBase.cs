﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}

public class VehControlBase : MonoBehaviour{
    public List<AxleInfo> axleInfos; 
    [SerializeField]
    private float maxMotorTorque, maxSteeringAngle, maxBrakeForce;

    public void ApplyLocalPositionToVisuals(WheelCollider collider){
        if (collider.transform.childCount == 0) {
            return;
        }
     
        Transform visualWheel = collider.transform.GetChild(0);
     
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);
     
        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    //x accelerate
    //o reverse
    //shoulder
    //Handles setting variables based on input
    void VehInput(ref float steering, ref float motor, ref float brake){
        //Motor, Forward has precedence
        motor = (Input.GetKey(KeyCode.S)) ? -maxMotorTorque : 0;    //Reverse
        motor = (Input.GetKey(KeyCode.W)) ? maxMotorTorque : motor; //Forward

        brake = (Input.GetKey(KeyCode.Space)) ? maxBrakeForce : 0; //Brake

        steering = maxSteeringAngle * Input.GetAxis("Horizontal"); //Steering

    }

    // Update is called once per frame
    void FixedUpdate(){
        float steerVal = 0, motorVal = 0, brakeVal = 0;

        VehInput(ref steerVal, ref motorVal, ref brakeVal);
     
        foreach (AxleInfo axleInfo in axleInfos) {
            //Apply only to steering wheels
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steerVal;
                axleInfo.rightWheel.steerAngle = steerVal;
            }

            //Apply only to drive wheels
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = motorVal;
                axleInfo.rightWheel.motorTorque = motorVal;

                axleInfo.leftWheel.brakeTorque = brakeVal;
                axleInfo.rightWheel.brakeTorque = brakeVal;
            }
            
            //Apply visuals
            ApplyLocalPositionToVisuals(axleInfo.leftWheel);
            ApplyLocalPositionToVisuals(axleInfo.rightWheel);
        }
    }
}

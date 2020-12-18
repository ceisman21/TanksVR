//Cooper Eisman December 13, 2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public HingeJoint Lever;
    public HingeJoint Wheel;
    public float maxForce;
    float Power;

    // Start is called before the first frame update
    void Start()
    {
        Power = 0;
        var Motor = Wheel.motor;
        Motor.force = 100;
        Motor.targetVelocity = 0;
        Motor.freeSpin = false;
        Wheel.motor = Motor;
        Wheel.useMotor = true;
    }

    // Update is called once per frame
    void Update()
    {
        Power = (Lever.angle / 80);
        var Motor = Wheel.motor;

        if (Power < -0.1 || Power > 0.1)
        {
            Motor.force = 100;
            Motor.targetVelocity = maxForce * Power;
            Motor.freeSpin = false;
            Wheel.motor = Motor;
        }
        else
        {
            Motor.force = 100;
            Motor.targetVelocity = 0;
            Motor.freeSpin = false;
            Wheel.motor = Motor;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private SliderJoint2D platform;
    [SerializeField] private float minPosition;
    [SerializeField] private float maxPosition;
    [SerializeField] private float speed;
    private bool isForward;
    private JointMotor2D platformMotor;

    private void FixedUpdate()
    {

        if (platform.jointTranslation <= minPosition)
        {
            if (!isForward)
            {
                isForward = true;
            }
        }

        if (platform.jointTranslation >= maxPosition)
        {
            if (isForward)
            {
                isForward = false;
            }
        }

        platformMotor = platform.motor;

        if (isForward)
        {
            platformMotor.motorSpeed = speed;
        }
        else
        {
            platformMotor.motorSpeed = -speed;
        }

        platform.motor = platformMotor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private SliderJoint2D platform;
    private bool isForward = false;
    private JointMotor2D platformMotor;

    private void FixedUpdate()
    {

        if (platform.jointTranslation <= 0.1f)
        {
            if (!isForward)
            {
                isForward = true;
            }
        }

        if (platform.jointTranslation >= 1.3f)
        {
            if (isForward)
            {
                isForward = false;
            }
        }

        platformMotor = platform.motor;

        if (isForward)
        {
            platformMotor.motorSpeed = 0.5f;
        }
        else
        {
            platformMotor.motorSpeed = -0.5f;
        }

        platform.motor = platformMotor;
    }
}

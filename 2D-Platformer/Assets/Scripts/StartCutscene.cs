using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public static bool isCutsceneOn;
    [SerializeField] private Animator cameraAnim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            isCutsceneOn = true;
            cameraAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 3f);
        }
    }

    private void StopCutscene()
    {
        isCutsceneOn = false;
        cameraAnim.SetBool("cutscene1", false);
        Destroy(gameObject);
    }
}

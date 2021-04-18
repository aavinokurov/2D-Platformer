using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameController : MonoBehaviour
{
    [SerializeField] private Transform mainCamera;
    [SerializeField] private Transform target;

    private void Update()
    {
        mainCamera.position = Vector3.MoveTowards(mainCamera.position, target.position, Time.deltaTime);
    }
}

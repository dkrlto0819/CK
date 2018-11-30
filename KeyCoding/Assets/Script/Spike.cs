using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour
{
    private float moveSpeed = 5.0f;

    void Start()
    {

    }
    void Update()
    {
        float SpikeX = moveSpeed * Time.deltaTime;
        transform.Translate(-SpikeX, 0, 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full in-game day in real-time seconds.")]
    [Min(1f)]
    public float dayLengthInSeconds = 120f; // Default: 2 minutes per day

    private void Update()
    {
        if (dayLengthInSeconds <= 0f)
            return;

        // Calculate how many degrees per second we need to rotate (360 degrees in a full day)
        float degreesPerSecond = 360f / dayLengthInSeconds;

        // Rotate the light around the X axis (pitch) to simulate the sun's movement
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProximityDetection : MonoBehaviour
{
    /// <summary>
    /// Meters to trigger the distance detection (eg: 1.5 meters). To set in the inspector
    /// </summary>
    public float DetectionRate = 0.0f;

    /// <summary>
    /// Transform of the player (in this case, the Main Camera)
    /// </summary>
    private Transform PlayerTransform;

    /// <summary>
    /// True if the player is close to the target
    /// </summary>
    private bool CloseEnough = false;

    /// <summary>
    /// Component that makes the image fade in/out
    /// </summary>
    private ImageFade ImageFader;

    /// <summary>
    /// True if the player triggered the proximity detection at least one time
    /// </summary>
    private bool ProximityTriggered = false;

    private void Start()
    {
        // Set the player transform as the camera
        // You can also set it in the inspector by making the field PlayerTransform 'public'
        PlayerTransform = Camera.main.transform;

        // Set the image fader
        // You can also set it in the inspector by making the field ImageFader 'public'
        ImageFader = gameObject.GetComponent<ImageFade>();
    }

    void Update()
    {
        if (Vector3.Distance(PlayerTransform.position, transform.position) <= DetectionRate
            && ProximityTriggered == false)
        {
            ImageFader.FadeImageOut(); // fade out the image

            CloseEnough = true;
            ProximityTriggered = true;
        }
        else
        {
            CloseEnough = false;
        }
    }
}
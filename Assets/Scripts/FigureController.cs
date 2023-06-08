using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FigureController : MonoBehaviour
{
    /// <summary>
    /// Meters to trigger the distance detection (eg: 1.5 meters). To set in the inspector
    /// </summary>
    [Tooltip("Specifies the meters to trigger the distance detection.")]
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
    /// Component that controls the image
    /// </summary>
    private ImageController ImageController;

    /// <summary>
    /// True if the player triggered the proximity detection at least one time
    /// </summary>
    private bool ProximityTriggered = false;

    /// <summary>
    /// True if the player triggered the touch event on the pillar
    /// </summary>
    [HideInInspector]
    public bool TouchEventTriggered { get; set; } = false;

    private void Awake()
    {
        // Set the player transform as the camera
        // You can also set it in the inspector by making the field PlayerTransform 'public'
        PlayerTransform = Camera.main.transform;

        // Set the image controller
        // You can also set it in the inspector by making the field ImageController 'public'
        ImageController = gameObject.GetComponent<ImageController>();
    }

    private void Start()
    {
        // Start by making the image transparent
        ImageController.MakeImageTransparent();
    }

    void Update()
    {
        // If the distance is at least DetectionRate and was never triggered before and the touch event is triggered
        if (Vector3.Distance(PlayerTransform.position, transform.position) <= DetectionRate
            && ProximityTriggered == false 
            && TouchEventTriggered == true)
        {
            ImageController.FadeImageOut(); // fade out the image

            CloseEnough = true;
            ProximityTriggered = true;
        }
        else
        {
            CloseEnough = false;
        }
    }

    public void FadeImageIn() => ImageController.FadeImageIn();

    public void FadeImageOut() => ImageController.FadeImageOut();
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProximityDetection : MonoBehaviour
{
    public float DetectionRate;
    private bool CloseEnough;
    private Transform PlayerTransform;

    private void Start()
    {

    }

    void Update()
    {
        CloseEnough = false;
        if (Vector3.Distance(PlayerTransform.position, transform.position) <= DetectionRate)
        {
            CloseEnough = true;
        }
        if (CloseEnough && Input.GetKeyUp(KeyCode.E))
        {
            //Open the door
        }
    }

    void OnGUI()
    {
        if(CloseEnough){
            //Do Open message stuff
        }
    }
}
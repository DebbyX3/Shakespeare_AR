using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEventsExample : MonoBehaviour, IMixedRealityTouchHandler
{
    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        Debug.Log("groda");
        string ptrName = eventData.SourceId.ToString();
        Debug.Log($"Touch started from {ptrName}");
    }
    public void OnTouchCompleted(HandTrackingInputEventData eventData) { }
    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
}

using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchEventsController : MonoBehaviour, IMixedRealityTouchHandler
{
    // To be assigned in the inspector
    public FigureController Figure1;
    public FigureController Figure2;
    public FigureController Figure3;

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        Debug.Log("Touch event triggered");

        if (Figure1.TouchEventTriggered == false)
        {
            Figure1.TouchEventTriggered = true;
            Figure1.FadeImageIn();
        }
        else if (Figure2.TouchEventTriggered == false)
        {
            Figure2.TouchEventTriggered = true;
            Figure2.FadeImageIn();
        }
        else if (Figure3.TouchEventTriggered == false)
        {
            Figure3.TouchEventTriggered = true;
            Figure3.FadeImageIn();
        }
    }

    public void OnTouchCompleted(HandTrackingInputEventData eventData) { }

    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance { get; private set; }

    public GameObject SlateText;
    public GameObject SlateVideo;

    [HideInInspector]
    public UnityEvent FigureDisppeared = new UnityEvent();

    // Variable that sets the number of disappeared figures to count.
    // When "HowManyFiguresDisappeared" reaches this value, it triggers an event
    [Tooltip("Sets the number of disappeared figures to count.")]
    public int DisappearedFiguresToCount = 3;

    // Sets the seconds to wait to display the slates after all the figures have disappeared
    [Tooltip("Sets the seconds to wait to display the slates after all the figures have disappeared.")]
    public int TimeToWaitToDisplaySlates = 5;

    // Counts how many figures disappeared
    private int HowManyFiguresDisappeared = 0;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SlateText.SetActive(false);
        SlateVideo.SetActive(false);

        FigureDisppeared.AddListener(OnFigureAppeared);
    }

    void OnFigureAppeared()
    {
        HowManyFiguresDisappeared++;

        // If all 3 figures disappeared
        if (HowManyFiguresDisappeared == DisappearedFiguresToCount)
        {
            StartCoroutine(OnAllFiguresDisappeared());
        }
    }

    IEnumerator OnAllFiguresDisappeared()
    {
        // Set a timer of "TimeToWaitToDisplaySlates" seconds and then display the slates
        yield return new WaitForSeconds(TimeToWaitToDisplaySlates);

        SlateText.SetActive(true);
        SlateVideo.SetActive(true);
    }
}

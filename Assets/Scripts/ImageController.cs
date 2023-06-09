using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageController : MonoBehaviour
{
    [HideInInspector]
    public Image Image { get; set; }

    private void Awake()
    {
        // Take the image attached to this GameObject
        // Alternatively, you can assign it in the inspector by removing [HideInInspector] and the line below
        Image = gameObject.GetComponent<Image>();
    }

    public void MakeImageTransparent()
    {
        Image.color = new Color(1, 1, 1, 0);
    }

    public void FadeImageIn()
    {
        StartCoroutine(FadeImage(false));
    }

    public void FadeImageOut()
    {
        StartCoroutine(FadeImage(true));        
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                Image.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                Image.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
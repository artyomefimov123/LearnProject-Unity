using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Image DamageImage;
    public void StartEffect()
    {
        StartCoroutine(ShowEffect());
    }

    public IEnumerator ShowEffect()
    {
        DamageImage.enabled = true;
        for (float t= 1f;t>0;t-=Time.deltaTime)
        {
            DamageImage.color = new Color(1, 0, 0, t);
            yield return null;
        }
        DamageImage.enabled = false;
        
    }
}

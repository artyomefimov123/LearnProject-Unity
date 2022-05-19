using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIcon : MonoBehaviour
{
    public Text Seconds;
    public Image Foreground;
    public Image Background;
   public void StartCharge()
    {
        Background.color = new Color(1f, 1f, 1f, 0.2f);
        Foreground.enabled = true;
        Seconds.enabled = true;
    }
    public void StopCharge()
    {
        Background.color = new Color(1f, 1f, 1f, 1f);
        Foreground.enabled = false;
        Seconds.enabled = false;
    }
    public void ShowCharge(float CurrentCharge,float FullCharge)
    {
        Foreground.fillAmount = CurrentCharge / FullCharge;
        Seconds.text = Mathf.Ceil(FullCharge - CurrentCharge).ToString();
    }
}

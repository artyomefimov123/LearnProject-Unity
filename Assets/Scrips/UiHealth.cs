using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHealth : MonoBehaviour
{
    public GameObject HealthUi;
    public List<GameObject> HealthIcons = new List<GameObject>();
    // Start is called before the first frame update
    public void Setup(int MaxHealth)
    {
        for (int i = 0;  i < MaxHealth; i++)
        {

            GameObject newIcon = Instantiate(HealthUi, transform);
            HealthIcons.Add(newIcon);
        }

    }
    public void DisplayHealth(int health)
    {
        for (int i = 0; i<HealthIcons.Count;i++)
        {
            if (i<health)
            {
                HealthIcons[i].SetActive(true);
            }
            else
            {
                HealthIcons[i].SetActive(false);
            }
        }
    }
}

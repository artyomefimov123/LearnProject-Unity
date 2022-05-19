using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automate : Gun
{
    [Header("Automate")]
    public int NumberOfBullet;
    public Text Bullets;
    public PlayerArmory PlayerArmory;

    public override void Shot()
    {
        base.Shot();
        NumberOfBullet -= 1;
        Bullets.text = "Пули: " + NumberOfBullet.ToString();
        if (NumberOfBullet == 0)
        {
            PlayerArmory.TakeGunByIndex(0);
        }
    }
    public override void Activate()
    {
        base.Activate();
        Bullets.enabled = true;
        Bullets.text = "Пули: " + NumberOfBullet.ToString();
    }
    public override void Deactivate()
    {
        base.Deactivate();
        Bullets.enabled = false;
    }
    public override void AddBullets(int NumberofBullets)
    {
        base.AddBullets(NumberofBullets);
        NumberOfBullet += NumberofBullets;
        Bullets.text = "Пули: " + NumberOfBullet.ToString();
    }
}

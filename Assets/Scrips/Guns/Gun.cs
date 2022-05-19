using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Spawn;
    public float Bulletspeed = 10f;
    public float Shotperiod = 0.2f;
    private float _timer;
    public AudioSource ShotSound;
    public GameObject Flash;
    public ParticleSystem ShotEffect;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer> Shotperiod)
        {
            if (Input.GetMouseButton(0))
            {
                _timer = 0;
                Shot();
            }
        }
        


    }
    public virtual void Shot()
    {
        GameObject newbullet = Instantiate(BulletPrefab, Spawn.position, Spawn.rotation);
        newbullet.GetComponent<Rigidbody>().velocity = Spawn.forward * Bulletspeed;
        ShotSound.Play();
        Flash.SetActive(true);
        Invoke("Hideflash", 0.12f);
        ShotEffect.Play();
    }
    public void Hideflash()
    {
        Flash.SetActive(false);
    }
    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }
    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }
    public virtual void AddBullets(int NumberofBullets)
    {

    }
}

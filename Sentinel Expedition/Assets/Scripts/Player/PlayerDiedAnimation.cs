using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDiedAnimation : MonoBehaviour
{
    public event EventHandler overHandler;
    public float pointsLifePlayer;
    public GameObject diedEffect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        pointsLifePlayer -= damage;
        if (pointsLifePlayer <= 0)
        {
            overHandler?.Invoke(this, EventArgs.Empty);
            Died();
        }
    }

    private void Died()
    {
        Instantiate(diedEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}

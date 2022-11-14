using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPlayer : MonoBehaviour
{
    public GameObject bulletRocks;
    public Transform spawnRockPosition;
    public float speed;
    public float shootTimer;
    private bool isShooting;
    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        ShootPlayer();
    }

    void ShootPlayer ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isShooting)
            {
                StartCoroutine(Shoot());
                
            }
    }

    IEnumerator Shoot()
    {
        int direction()
        {
            if(transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }

        isShooting = true;

        GameObject newBullet = Instantiate(bulletRocks, spawnRockPosition.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * direction() * Time.fixedDeltaTime, 0f);
        newBullet.transform.localScale = new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y);

        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}

using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float damageAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager gm = GameManager.instance;

        if (gm != null)
        {
            if (gm.asteroidList != null)
            {
                gm.asteroidList.Add(this);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);

    }


    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damageAmount);
            Debug.Log(health.currentHealth);
            GameManager gm = GameManager.instance;

            if (gm != null)
            {
                if (gm.asteroidList != null)
                {
                    gm.asteroidList.Remove(this);
                }
            }
            Destroy(gameObject);
        }
    }

    public void OnDestory()
    {
        GameManager gm = GameManager.instance;
        if (gm != null)
        {
            if (gm.asteroidList != null)
            {
                gm.asteroidList.Remove(this);
            }
        }
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

    public float lifetime;

    public float damageAmount;

    public Rigidbody rb;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        }

        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}

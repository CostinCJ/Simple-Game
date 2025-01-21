using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeedY;
    public float rotationSpeedX;
    public float rotationSpeedZ;
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy the collectible
        Destroy(gameObject);

        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }

}

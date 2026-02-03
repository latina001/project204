using UnityEngine;

public class Bullet : MonoBehaviour
{
    float force;
    Rigidbody rb;

    void Start()
    {
      rb = GetComponent<Rigidbody>();
        force = 10.4f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0,0,force));
    }
}

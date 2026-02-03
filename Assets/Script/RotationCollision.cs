using UnityEngine;

public class RotationCollision : MonoBehaviour
{
    [SerializeField] float torque;
    Rigidbody rb;

    void Start()
    {
       //b = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
   void Update()
     {
        //b.AddForce(new Vector3(0, 0, force));
     }

    private void OnCollisionEnter(Collision other)
    {
        other.rigidbody.AddTorque(Vector3.up * torque);
    }
}

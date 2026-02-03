using UnityEngine;

public class ChangeObjestColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.green;
        other.gameObject.GetComponent<Renderer>().material.color= Color.black;
    }
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.lightBlue;
        other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

}

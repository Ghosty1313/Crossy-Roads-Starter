using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        Body.AddForce(new Vector3(-5, 0, 0));
    }
}

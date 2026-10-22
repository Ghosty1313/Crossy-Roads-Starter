using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] GameManager gm;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="car")
        {
            gm.NewLevel();
        }
    }
}

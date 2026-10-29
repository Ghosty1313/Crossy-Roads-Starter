using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] GameManager gm;

    private void OnTriggerEnter(Collider Collider)
    {
        if(Collider.gameObject.tag=="car")
        {
            gm.NewLevel();
        }
    }
}

using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] Transform PlayerPos;
    private bool Chase = false;

    private void Update()
    {
        if (Chase)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerPos.position, speed * Time.deltaTime);
        }
    }

    public void chaseStart(Transform PlayerPos)
    {
        Chase = true;
    }

    public void chaseEnd()
    {
        Chase = false;
    }
}

using UnityEngine;

public class ChessPuzzleScript : MonoBehaviour
{
    [SerializeField] GameObject piece;
    [SerializeField] GameObject otherStand;
    public bool completed;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == piece)
        {
            completed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == piece)
        {
            completed = false;
        }
    }
}

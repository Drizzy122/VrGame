using UnityEngine;

public class UnlockDrawer : MonoBehaviour
{
    public GameObject chessPuzzle1;
    public GameObject chessPuzzle2;
    public bool done = false;
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            bool cp1 = chessPuzzle1.GetComponent<ChessPuzzleScript>().completed;
            bool cp2 = chessPuzzle2.GetComponent<ChessPuzzleScript>().completed;
            if (cp1 && cp2)
            {
                done = true;
                Unlock();
            }
        }
    }
    void Unlock()
    {
        gameObject.AddComponent<XRGrabIneractableTwoAttach>();
        gameObject.AddComponent<Rigidbody>();
        AS.Play();
        Debug.Log("hi");

    }
}

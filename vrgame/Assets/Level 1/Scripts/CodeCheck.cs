using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCheck : MonoBehaviour
{
    public GameObject screenCode;
    Animator animator;
    AudioSource source;
    [SerializeField] GameObject door;
    bool open;
    // Start is called before the first frame update
    void Start()
    {
        open= false;
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (screenCode.GetComponent<CodeController>().correct && !open)
        {
            Activate();
        }
    }
    void Activate()
    {
        source.Play();
        animator.enabled = true;
        open = true;
    }
}

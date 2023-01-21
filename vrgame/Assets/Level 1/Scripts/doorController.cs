using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    [Header("this GameObject will open the door")]
    public GameObject key;
    AudioSource sound;
    [SerializeField] List<AudioClip> clips = new List<AudioClip>();
    public GameObject door;
    Animator DoorAnim;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
        DoorAnim = door.GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == key) 
        {
            Debug.Log("Door Open");
            sound.clip = clips[0];
            sound.Play();
            DoorAnim.enabled = true;
        }
        else
        {
            sound.clip = clips[1];
            sound.Play();
        }
    }
}

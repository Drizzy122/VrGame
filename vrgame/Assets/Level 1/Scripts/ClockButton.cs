using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class ClockButton : MonoBehaviour
{
    [Header("this GameObject will open turn on clock")]
    [SerializeField] GameObject button;
    [SerializeField] TMP_Text display;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == button)
        {
            Debug.Log("clock on Open");
            display.gameObject.SetActive(true);
            DisableButton();


        }
    }
    private void DisableButton()
    {
        button.GetComponent<XRGrabInteractable>().enabled = false;
        Destroy(button.GetComponent<XRGrabInteractable>());
        Destroy(button.GetComponent<Rigidbody>());
        button.transform.SetParent(transform);
        button.transform.localPosition = new Vector3(0.0102000004f, -9.99999975e-05f, 0.00209999993f);
        button.transform.localRotation = new Quaternion(0, 0.707106829f, 0, 0.707106829f);



    }
}

using Photon.Pun;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float TurnSpeed = 4f;
    private PhotonView View;
    private Camera playerCamera;
    void Start()
    {
        View = GetComponent<PhotonView>();
        if (View.IsMine)
        {
            // Assign the local player's camera
            playerCamera = Camera.main;
            playerCamera.enabled = true;
        }
        else
        {
            // Disable camera for other players
            gameObject.GetComponentInChildren<Camera>().enabled = false;
        }

    }

    
    void Update()
    {
        if (!View.IsMine) return;
        float Mycamara = playerCamera.transform.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, Mycamara, 0), TurnSpeed * Time.deltaTime);
    }
}

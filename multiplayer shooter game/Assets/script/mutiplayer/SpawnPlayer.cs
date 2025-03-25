using UnityEngine;
using Photon.Pun;
public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}

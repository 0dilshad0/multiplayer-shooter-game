using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;
public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public TMP_InputField create;
    public TMP_InputField join;
   
   public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("game");
    }
}

using Photon.Pun;
using Photon.Realtime;
using Photon;
using UnityEngine;
using UnityEngine.UI;

internal class Player1 : MonoBehaviourPun
{
    Text _nickName;
    PhotonView _view;

    private void Start()
    {
        _nickName.text = _view.Owner.NickName;
    }
}


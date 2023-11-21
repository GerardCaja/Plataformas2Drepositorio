using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{

    public void BombStuff()
    {
        GameManager.instance.ReducirCorazonesUI();
        SoundManager.instance.Bomb();
    }

    public void DestroyBomb()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    public int vidas = 3;
    public int estrellas = 0;
    public Canvas ui;
    public GameObject[] corazonesGrupo;
    public GameObject[] estrellasGrupo;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AumentarEstrellasUI()
    {
        estrellasGrupo[estrellas].SetActive(true);
        estrellas++;

        if(estrellas >= 5)
        {
            SceneManager.LoadScene("Victoria");
        }
    }

    public void ReducirCorazonesUI()
    {
        corazonesGrupo[vidas-1].SetActive(false);
        vidas--;

        if(vidas <= 0)
        {
            SceneManager.LoadScene("Derrota");
        }
    }

    // Update is called once per frame
    public void GameOver()
    {
        Debug.Log("GameManager");
    }
}

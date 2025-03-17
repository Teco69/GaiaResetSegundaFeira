using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrocarMap : MonoBehaviour
{
    public string cena;

    public void Play()
    {
        SceneManager.LoadScene(cena);
    }
}

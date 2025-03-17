using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarMapaEmJogo : MonoBehaviour
{
    
    public string cena;
   private void OnMouseDown(){
    SceneManager.LoadScene(cena);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{
    //Mon bouton "Retour" que je vais utiliser en prefab.
    public void returnButton()
    {
        SceneManager.LoadScene("MainMenu"); //Chargement de la scène Main Menu
    }
}

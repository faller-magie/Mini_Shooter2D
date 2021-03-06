﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Ajout du scene management car j'ai besoin de gérer les scènes

public class MenuScript : MonoBehaviour
{
    //Mon bouton "Jouer"
    public void playButton()
    {
        SceneManager.LoadScene("Game"); //Chargement de la scène "Game"
    }

    //Mon bouton "Instructions"
    public void howToButton()
    {
        SceneManager.LoadScene("Instructions");//Chargement de la scène "Instructions"
    }

    //Mon bouton "Crédits"
    public void creditsButton()
    {
        SceneManager.LoadScene("Credits");//Chargement de la scène "Crédits"
    }

    //Mon bouton "Quitter"
    public void quitButton()
    {
        Debug.Log("Quitte le jeu");
        Application.Quit(); //Arrête l'application et ferme le jeu
    }
}

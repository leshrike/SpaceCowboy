using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState{

    menu,
    inGame,
    gameOver

}

public class GameManager : MonoBehaviour
{

    public int collectedObject = 0;
    public GameState currentGameState = GameState.menu;
    public static GameManager sharedInstance;
    private PlayerController controller;

    void Awake(){

        if(sharedInstance == null){

            sharedInstance = this;
        }
    }

    public void startGame(){

        currentGameState = GameState.inGame;
        collectedObject = 0;
        SceneManager.LoadScene("CaveLevel");
       

    }

    public void showInstructions(){

        currentGameState = GameState.menu;
        SceneManager.LoadScene("HowToPlay");
    }

    public void gameOver(){

        currentGameState = GameState.gameOver;
        SceneManager.LoadScene("GameOver");

    }

    public void backToMenu(){

        currentGameState = GameState.menu;
        SceneManager.LoadScene("MainMenu");

    }

    public void collectObject(){

        //collectedObject += collectable.value;
    }

}

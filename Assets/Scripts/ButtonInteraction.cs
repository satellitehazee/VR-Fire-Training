using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonInteraction : MonoBehaviour
{
    private void Start(){
        Button _startButton = null;
        Button _aboutButton = null;
        Button _tutorialButton = null;
        Button _quitButton = null;
        GameObject MainMenu = this.gameObject; // the script is placed on the main menu object
        GameObject AboutMenu = this.transform.parent.GetChild(1).gameObject;
        Button _aboutBack = AboutMenu.GetComponentInChildren<Button>();
        Button[] menuButtons = this.GetComponentsInChildren<Button>(true);
        for(int i = 0; i< menuButtons.Length; i++)
        {
            if(menuButtons[i].name == "ButtonStart") _startButton = menuButtons[i];
            if (menuButtons[i].name == "ButtonTutorial") _tutorialButton = menuButtons[i];
            if (menuButtons[i].name == "ButtonAbout") _aboutButton = menuButtons[i];
            if(menuButtons[i].name == "ButtonQuit") _quitButton = menuButtons[i];
        }
        _startButton.onClick.AddListener(() => SceneManager.LoadScene(1));
        _aboutButton.onClick.AddListener(() => {
            MainMenu.SetActive(false);
            AboutMenu.SetActive(true);
            });
        _tutorialButton.onClick.AddListener(() => SceneManager.LoadScene(2));
        _quitButton.onClick.AddListener(() => Application.Quit());
        _aboutBack.onClick.AddListener(() => {
            AboutMenu.SetActive(false);
            MainMenu.SetActive(true);
        });
    }
    public void AlternativeButton(Button button){
        if(Input.GetKeyDown(KeyCode.Space)) button.onClick.Invoke();
    }
}

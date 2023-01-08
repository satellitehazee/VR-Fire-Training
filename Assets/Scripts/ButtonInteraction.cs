using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteraction : MonoBehaviour
{
    // Start is called before the first frame update

    public void ChangeScene(int sceneID){
        SceneManager.LoadScene(sceneID);
    }
}

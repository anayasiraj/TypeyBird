using UnityEngine;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    /*
        Starts game when "Play" button in Title Scene is pressed
    */

    public void StartGame() => SceneManager.LoadScene("GameScene", LoadSceneMode.Single); 


}

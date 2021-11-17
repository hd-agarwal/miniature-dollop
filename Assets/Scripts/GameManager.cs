using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float restartDelay=1f;
    bool hasGameEnded=false;
    public GameObject levelComplete;
    public void EndGame(){
        if(!hasGameEnded){
            hasGameEnded=true;
            Debug.Log("Game over");
            Invoke("Restart",restartDelay);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        levelComplete.SetActive(true);
    }
}

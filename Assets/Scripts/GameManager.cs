using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public Text playerGoldText;
    void Start()
    {
        
    }

    void Update()
    {
        playerGoldText.text = "°ñµå : " + gold;

    }

    public void Onclick()
    {
        gold++;
    }

    public void Dungeon()
    {
        SceneManager.LoadScene("Dungeon");
    }
}

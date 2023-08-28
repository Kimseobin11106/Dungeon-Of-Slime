using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyManager : MonoBehaviour
{
    public int enemyHP;
    public int playerDmg;
    public Text enemyHPText;
    public Text resultDungeon;

    void Start()
    {
        resultDungeon.gameObject.SetActive(false);
    }

    void Update()
    {
        enemyHPText.text = "Àû Ã¼·Â : " + enemyHP;

        if (enemyHP <= 0)
            resultDungeon.gameObject.SetActive(true);
           // Invoke("PlayScene()", 3f);
            
    }

    void PlayScene()
    {
        SceneManager.LoadScene("Play");
    }

    public void HitEnemy()
    {
        enemyHP -= playerDmg;
    }
}

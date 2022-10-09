using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float m_score;
    bool m_isGameOver;

    public float enemySpawnDowntime = 3.0f;
    float m_enemySpawnTime;

    public GameObject enemy;

    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_isGameOver = false;
        m_enemySpawnTime = 0;

        m_ui = FindObjectOfType<UIManager>();
        m_ui.setScoreText("Score:" + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_enemySpawnTime -= Time.deltaTime;

        if (m_isGameOver)
        {
            m_enemySpawnTime = 0;
            m_ui.showGameOverPanel(true);
            return;
        }

        if (m_enemySpawnTime <= 0)
        {
            spawnEnemy();
            m_enemySpawnTime = enemySpawnDowntime;
        }
    }

    void spawnEnemy()
    {
        Vector2 ePos = new Vector2(Random.Range(-5, 5), 9);

        if (enemy)
        {
            Instantiate(enemy, ePos, Quaternion.identity);
        }
    }

    public void setScore(int s)
    {
        m_score = s;
    }

    public float getScore()
    {
        return m_score;
    }

    public bool isGameOver()
    {
        return m_isGameOver;
    }

    public void setGameOverState(bool state)
    {
        this.m_isGameOver = state; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float m_score;
    bool m_isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        m_isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

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

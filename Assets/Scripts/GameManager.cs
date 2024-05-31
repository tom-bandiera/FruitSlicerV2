using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int m_life = 3;
    private int m_score = 0;
    [SerializeField] private GameObject m_gameOverScreen;

    private void Start()
    {

    }

    private void Update()
    {
        if (m_life <= 0)
        {
            GameOver();
        }
    }

    internal void AddScore(int _score)
    {
        m_score += _score;
    }

    internal void TakeDamage(int _damage)
    {
        m_life -= _damage;
    }

    internal void AddLife(int _life)
    {
        if (m_life < 3) { m_life += _life; }
    }

    internal int GetLife()
    {
        return m_life;
    }


    internal int GetScore()
    {
        return m_score;
    }

    internal void GameOver()
    {
        Time.timeScale = 0;
        m_gameOverScreen.SetActive(true);
    }

    public void NewGame()
    {
        m_score = 0;
        m_life = 3; 
        
        m_gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
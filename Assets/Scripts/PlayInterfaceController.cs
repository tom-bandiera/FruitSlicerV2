using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayInterfaceController : MonoBehaviour
{
    public GameManager m_gameManager;
    [SerializeField] TMP_Text m_scoreText;
    [SerializeField] TMP_Text m_lifeText;
    private string m_scoreLabel;
    private string m_lifeLabel;

    // Start is called before the first frame update
    void Start()
    {
        m_lifeLabel = m_lifeText.text;
        m_scoreLabel = m_scoreText.text;

    }

    // Update is called once per frame
    void Update()
    {
        m_lifeText.text = m_lifeLabel + m_gameManager.GetLife();
        m_scoreText.text = m_scoreLabel + m_gameManager.GetScore();
    }
}

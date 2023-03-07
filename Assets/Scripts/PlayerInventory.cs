using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public class PlayerInventory : MonoBehaviour
{
    [SerializeField] TMP_Text LevelCompleteText;

    public int NumberOfPapers { get; private set; }

    public UnityEvent<PlayerInventory> OnPaperCollected;

    // Start is called before the first frame update
    void Start()
    {
        LevelCompleteText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PaperCollected()
    {
        NumberOfPapers++;
        OnPaperCollected.Invoke(this);

        if (NumberOfPapers == 5)
        {
            GameComplete();
            Time.timeScale = 0f;
        }
    }

    public void GameComplete()
    {
        LevelCompleteText.gameObject.SetActive(true);
    }
}

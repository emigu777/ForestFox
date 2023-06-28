using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    //[SerializeField] 
    //private Text _livestext;

    [SerializeField] 
    private TextMeshProUGUI _scoretext;

    public void scoreText(int _score)
    {
        _scoretext.text = "Score: " + _score;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

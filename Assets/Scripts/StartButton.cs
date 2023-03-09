using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;

    private StartMenuUIHandler uiHandler;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
        uiHandler = GameObject.Find("GameManager").GetComponent<StartMenuUIHandler>();
    }

    public void StartGame()
    {
        uiHandler.StartNew();
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClicked : MonoBehaviour
{
	public Button yourButton;
    private GameObject screen;
    private GameObject backButton;
    void Start()
    {
        yourButton.onClick.AddListener(TaskOnClick);
        screen = GameObject.Find("CharacterScreen");
        backButton = GameObject.Find("Button_Back");
    }

    public void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        screen.SetActive(true);
        backButton.SetActive(true);
    }
}
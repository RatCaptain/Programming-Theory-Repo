using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField animalNameInputField;
    public TMP_Dropdown animalTypeDropDown;

    void MoveData()
    {
        MenuManager.Instance.animalName = animalNameInputField.text;
        MenuManager.Instance.animalType = animalTypeDropDown.captionText.text;
    }
    public void StartGame()
    {
        MoveData();
        SceneManager.LoadScene(1);
    }
}

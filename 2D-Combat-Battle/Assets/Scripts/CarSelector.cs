using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class CarSelector : MonoBehaviour
{
    //[SerializeField] public Button previousButton;
    //[SerializeField] public Button nextButton;
    //private int currentCar;

    
    //public void SelectCar(int _index)
    //{
    //    previousButton.interactable = (_index != 0);
    //    nextButton.interactable = (_index != transform.childCount - 1);
    //    for (int i = 0; i < transform.childCount; i++)
    //    {
    //        transform.GetChild(i).gameObject.SetActive(i == _index);      
    //    }
    //}

    //public void ChangeCar(int _change)
    //{
    //    currentCar += _change;
    //    SelectCar(currentCar);
    //}

    public GameObject[] characters;
    public int selectedCharacter = 0;
    public TMP_Text Label;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);

        //if (selectedCharacter == characters.Length)
        //{
        //    NextCharacter.
        //}
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }
    

    public void StartGame()
    {

        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
    public void SelectCharacter()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene("MainMenu");

    }


}
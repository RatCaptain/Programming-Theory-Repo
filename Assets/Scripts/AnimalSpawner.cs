using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[2];
    private GameObject animalToSpawn;
    private GameObject animalname;
    private TextMeshProUGUI animalnameText;

    private void Start() 
    {
        animalDeclare();
        Spawn();
    }

    void animalDeclare()
    {
        if (MenuManager.Instance.animalType == "Cat")
        {
            animalToSpawn = prefabs[0];
        }
        else
        {
            animalToSpawn = prefabs[1];
        }
    }
    void Spawn()
    {
        
        Instantiate(animalToSpawn, new Vector3(0, 0, 0), Quaternion.identity);
        animalname = GameObject.Find("Animal name");
        animalnameText = animalname.GetComponent<TextMeshProUGUI>();
        animalnameText.text = MenuManager.Instance.animalName;
    }


}

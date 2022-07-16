using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;

    public TMP_Text Label;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        transform.localScale = new Vector3(71, 71, 71);
        //Quaternion.identity

       GameObject clone = Instantiate(prefab, spawnPoint.position,spawnPoint.rotation,transform);
        //Animator anim = spawnPoint.GetComponent<Animator>();
        //clone.AddComponent();
        
        Label.text = prefab.name;
    }

    //void CopyValues<T>(T from, T to)
    //{
    //    var json = JsonUtility.ToJson(from);
    //    JsonUtility.FromJsonOverwrite(json, to);
    //}

}

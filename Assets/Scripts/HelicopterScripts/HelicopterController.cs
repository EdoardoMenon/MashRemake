using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelicopterController : MonoBehaviour
{
    [SerializeField]
    private Text soldiersRescuedTF;
    [SerializeField]
    private Text peopleInHelicopterTF;
    [SerializeField]
    private AudioSource collectPersonAudioSrc;

    private int peopleInHelicopter = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
        if (soldiersRescuedTF.text == "10")
        {
            SceneManager.LoadScene("VictoryScreen");
        }
    }

    public void CollectPerson(GameObject personToRemove)
    {
        if (peopleInHelicopter < 3)
        {
            collectPersonAudioSrc.Play();
            peopleInHelicopterTF.text = AddIntToString(peopleInHelicopterTF.text);
            peopleInHelicopter += 1;
            Destroy(personToRemove);
        }
    }

    public int GetPeopleInHelicopter()
    {
        return peopleInHelicopter;
    }

    public void UnloadPeople()
    {
        if (peopleInHelicopter > 0)
        {
            collectPersonAudioSrc.Play();
            soldiersRescuedTF.text = AddIntToString(soldiersRescuedTF.text, peopleInHelicopter);
            peopleInHelicopterTF.text = "0";
            peopleInHelicopter = 0;
        }
    }

    private string AddIntToString(string text, int amountToAdd = 1)
    {
        int textAsInt = int.Parse(text);
        textAsInt += amountToAdd;
        return textAsInt.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelicopterController : MonoBehaviour
{
    [SerializeField]
    private Text score;
    private int peopleInHelicopter = 0;

    void Update()
    {

    }

    public void CollectPerson(GameObject personToRemove)
    {
        if (peopleInHelicopter < 3)
        {
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
            int currScore = int.Parse(score.text);
            currScore += peopleInHelicopter;
            score.text = currScore.ToString();
            peopleInHelicopter = 0;
        }
    }
}

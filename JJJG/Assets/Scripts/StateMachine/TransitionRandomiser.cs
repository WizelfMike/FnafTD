using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class TransitionRandomiser : MonoBehaviour
{
    [SerializeField] private Animator animatronicAnimator;
    
    [SerializeField] private int difficultyMultiplier;

    [SerializeField] ButtonToggle door;

    [SerializeField] private int minTime;
    [SerializeField] private int maxTime;
    private int waitTime;

    [SerializeField] private bool animatronicActive = true;

    public bool isAtDoor;
    private bool spawnCoroutineStarted = false;
    private bool resetCouroutines = false;

    private void Start()
    {
        isAtDoor = false;
    }

    private void Update()
    {
        if (!spawnCoroutineStarted)
        {
            spawnCoroutineStarted = true;

            Debug.Log("COUROTINE");

            StartCoroutine(CalculateMoveOn());
        }
    }

    public void IsAtDoorCheck()
    {
        isAtDoor = true;
    }

    public void IsNotAtDoorCheck()
    {
        isAtDoor = false;
    }

    public void ResetCourotine()
    {
        StopCoroutine(CalculateMoveOn());
        spawnCoroutineStarted = false;
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void MoveOnTrigger()
    {
        animatronicAnimator.SetTrigger("MoveOn");
    }

    public void ResetBackToDefault()
    {
        Debug.Log("BACK TO START");
        animatronicAnimator.SetTrigger("Reset");
        StopCoroutine(CalculateMoveOn());
    }

    public void Jumpscare()
    {
        Debug.Log("AAAAAAAAAAAAAAA");
        animatronicAnimator.SetTrigger("Jumpscare");
    }

    IEnumerator CalculateMoveOn()
    {
        while (animatronicActive)
        {
            waitTime = Random.Range(minTime, maxTime);

            yield return new WaitForSeconds(waitTime);

            int randomNumber = Random.Range(1, 21);

            if (isAtDoor == false)
            {
                if (difficultyMultiplier > randomNumber)
                {
                    MoveOnTrigger();
                    yield break;
                }

                if (difficultyMultiplier < randomNumber)
                {
                    
                }
            }

            if (isAtDoor == true)
            {
                if (difficultyMultiplier > randomNumber && door.isClosed == true)
                {
                    ResetBackToDefault();
                    yield break;
                }

                if (difficultyMultiplier > randomNumber && door.isClosed == false)
                {
                    Jumpscare();
                    yield break;
                }

                if (difficultyMultiplier < randomNumber)
                {
                    Debug.Log("Stopped");
                }
            }
        }
    }
}

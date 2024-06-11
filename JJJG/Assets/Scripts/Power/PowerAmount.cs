using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerAmount : MonoBehaviour
{
    public float powerAmount = 100f; //IF IT REACHES ZERO YOU DIE

    [SerializeField] private bool powerIsOn;
    private bool spawnCoroutineStarted = false;

    [SerializeField] private float constantReduction;
    [SerializeField] private float doorPowerReduction;

    [SerializeField] public ButtonToggle rightDoor;
    [SerializeField] public ButtonToggle leftDoor;

    [SerializeField] private TMP_Text powerText;

    [SerializeField] private GameObject power1;
    [SerializeField] private GameObject power2;

    private void Start()
    {
        powerIsOn = true;
    }

    private void Update()
    {
        if (powerAmount <= 0f)
        {
            powerIsOn = false;

            StopCoroutine(ReducePower());

            rightDoor.isClosed = false;
            leftDoor.isClosed = false;
        }

        if (!spawnCoroutineStarted && powerIsOn)
        {
            spawnCoroutineStarted = true;

            StartCoroutine(ReducePower());
        }

        powerText.text = powerAmount.ToString("0");

        var one = leftDoor.isClosed | rightDoor.isClosed ? true : false;
        power1.SetActive(one);

        var two = leftDoor.isClosed && rightDoor.isClosed ? true : false;
        power2.SetActive(two);
    }

    IEnumerator ReducePower()
    {
        while (powerIsOn)
        {
            yield return new WaitForSeconds(0.5f);

            constantReducer();

            yield return new WaitForSeconds(0.5f);
        }
    }

    private void constantReducer()
    {
        powerAmount -= constantReduction;

        if (leftDoor.isClosed)
        {
            powerAmount -= doorPowerReduction;
        }

        if (rightDoor.isClosed)
        {
            powerAmount -= doorPowerReduction;
        }

        
    }
}

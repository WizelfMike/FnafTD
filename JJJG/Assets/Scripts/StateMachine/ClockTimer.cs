using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ClockTimer : MonoBehaviour
{
    [SerializeField] private int timer;

    [SerializeField] private TMP_Text timerText;
    private bool coroutineStarted;

    private void Update()
    {
        if (!coroutineStarted)
        {
            coroutineStarted = true;

            StartCoroutine(ClockTimerCourotine());
        }
    }

    IEnumerator ClockTimerCourotine()
    {
        while (true)
        {
            yield return new WaitForSeconds(60);

            timer++;

            timerText.text = timer.ToString();

            if (timer >= 6)
            {
                Debug.Log("DING DONG DING DONG. DONG DONG DING DONG");

                SceneManager.LoadScene("WinScene");
            }
        }
    }
}

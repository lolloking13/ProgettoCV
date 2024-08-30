using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceManager : MonoBehaviour
{
    public float timeLeft = 3f;

    [Header("UI")]
    public GameObject[] playerInputUI;
    public Text iaInputText;
    public Image countDownImageFill;

    private void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown() {
        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            yield return null;

            countDownImageFill.fillAmount = timeLeft / 3;
        }

        IaInputSelection();
    }

    public void IaInputSelection()
    {
        int selection = Random.Range(0, 4);

        string s = "";
        if (selection == 0) s = "W";
        else if (selection == 1) s = "A";
        else if (selection == 2) s = "S";
        else if (selection == 3) s = "D";

        iaInputText.text = s;
    }
}

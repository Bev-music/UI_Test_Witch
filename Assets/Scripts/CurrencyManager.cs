using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    [Header("Currency Manager")]  
    [SerializeField] float currentPower = 1;
    [SerializeField] float powerIncrease = 5f;
    [SerializeField] float currency = 1800f;
    [SerializeField] float currentLevel = 1f;
    [SerializeField] float levelUpCost = 100f;
    [SerializeField] TMP_Text textCurrency;
    [SerializeField] TMP_Text level;
    [SerializeField] TMP_Text Power;
    [SerializeField] Button levelUpButton;

    void Start()
    {
        level.text = currentLevel.ToString();
        Power.text = currentPower.ToString();

    }

    void Update()
    {
        DisableButton();
    }

    // On cutton click currency depletes
    public void LevelUP()
    {
        if (currency >= levelUpCost)
        {
            currency = currency - levelUpCost;
            ++currentLevel;
            currentPower = Mathf.Round(((currentPower + powerIncrease) * currentLevel) / 10);
            textCurrency.text = currency.ToString();
            level.text = currentLevel.ToString();
            Power.text = currentPower.ToString();
        }

    }

    void DisableButton()
    {
        if (currency < levelUpCost)
        {
            levelUpButton.interactable = false;

        }
    }

}

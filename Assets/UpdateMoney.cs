using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoney : MonoBehaviour
{
    public int balance;
    public int addPoint;
    public int[] costAmounts;

    public TextMeshProUGUI balanceCounter;

    public GameObject onPlayerHat, onPlayerGlasses;
    public Button glassesButton, hatButton;


    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        if (balance >= costAmounts[0])
        {
            glassesButton.interactable = true;
        }
        if (balance >= costAmounts[1])
        {
            hatButton.interactable = true;
        }

        balanceCounter.text = $"Money: {balance}";

    }

    public void BuyHat()
    {
        if (balance >= costAmounts[0])
        {
            balance -= costAmounts[0];
            onPlayerHat.SetActive(true);
        }
    }
    public void BuyGlasses()
    {
        if (balance >= costAmounts[1])
        {
            Debug.Log("yes");
            balance -= costAmounts[1];
            onPlayerGlasses.SetActive(true);
        }
    }

    public void AddPoint()
    {
        balance += addPoint;
    }


}
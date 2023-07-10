using System;
using UnityEngine;

public class Challenge_Easy_Tip_Calculator_Solution : MonoBehaviour
{
    private enum TipAmounts
    {
        _15,
        _20,
        _25,
        CUSTOM
    }

    [SerializeField] private float Bill;
    [SerializeField] private TipAmounts CurrentTipAmount;
    [SerializeField] private float CustomTipAmount;

    void Start()
    {
        Debug.Log("Your bill is $" + $"{Bill:0.00}");
        switch (CurrentTipAmount)
        {
            case TipAmounts._15:
                Debug.Log("15% tip = $" + $"{Bill * 0.15f:0.00}" + " with a final total of: $" +
                          $"{Bill * 1.15f:0.00}");
                break;
            case TipAmounts._20:
                Debug.Log("20% tip = $" + $"{Bill * 0.2f:0.00}" + " with a final total of: $" + $"{Bill * 1.2f:0.00}");
                break;
            case TipAmounts._25:
                Debug.Log("25% tip = $" + $"{Bill * 0.25f:0.00}" + " with a final total of: $" +
                          $"{Bill * 1.25f:0.00}");
                break;
            case TipAmounts.CUSTOM:
                Debug.Log("Your custom tip of " + $"{CustomTipAmount:0.00}" + "% = $" +
                          $"{Bill * (CustomTipAmount / 100):0.00}" + " with a final total of $" +
                          $"{Bill * (1 + CustomTipAmount / 100):0.00}");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
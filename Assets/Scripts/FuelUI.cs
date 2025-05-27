using TMPro;
using UnityEngine;

public class FuelUI : MonoBehaviour
{
    public FloatSO currentFuel;

    public TMP_Text fuelText;

    public void Update()
    {
        fuelText.text = "Fuel: " + Mathf.Round(currentFuel.value * 100.0f) / 100.0f;
    }
}

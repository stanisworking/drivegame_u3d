using UnityEngine;
using UnityEngine.Events;

public class FuelSystem : MonoBehaviour
{
    public float consumptionRate = 10.0f;

    public FloatSO currentFuel;

    public UnityEvent OnFuelEmpty;

    void Start()
    {
        currentFuel.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        currentFuel.value -= consumptionRate * Time.deltaTime;

        if (currentFuel.value <= 0)
        {
            currentFuel.value = 0;
            OnFuelEmpty.Invoke();
        }
    }
}

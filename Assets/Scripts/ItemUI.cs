using TMPro;
using UnityEngine;

public class ItemUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TMP_Text itemCountText;
    int itemCount = 0;

    public void UpdateItemCount() {
        itemCount++;
        itemCountText.text = "" + itemCount;
    }
}

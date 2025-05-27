using UnityEngine;

public class SpriteSelector : MonoBehaviour
{
    public SpriteTable spriteTable;

    SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (TryGetComponent<SpriteRenderer>(out sr)) {
            sr.sprite = spriteTable.SelectRandom();   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "SpriteTable", menuName = "Scriptable Objects/SpriteTable")]
public class SpriteTable : ScriptableObject
{
    public Sprite[] sprites;

    public Sprite SelectRandom()
    {
        var n = UnityEngine.Random.Range(0, sprites.Length);
        return sprites[n];
    }
}

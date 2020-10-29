using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public SpriteRenderer playerSR;

    private void Awake()
    {
        playerSR.sprite = SkinManager.equippedSkin;
    }
}
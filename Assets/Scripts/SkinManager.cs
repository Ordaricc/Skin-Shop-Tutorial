using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static Sprite equippedSkin;

    public SSkinInfo[] allSkins;

    private void Awake()
    {
        string lastSkinUsed = PlayerPrefs.GetString("skinPref", SSkinInfo.SkinIDs.brown.ToString());
        foreach (SSkinInfo s in allSkins)
        {
            if (s.skinID.ToString() == lastSkinUsed)
            {
                EquipSkin(s);
            }
        }
    }

    public void EquipSkin(SSkinInfo skinInfo)
    {
        equippedSkin = skinInfo.skinSprite;
        PlayerPrefs.SetString("skinPref", skinInfo.skinID.ToString());
    }
}
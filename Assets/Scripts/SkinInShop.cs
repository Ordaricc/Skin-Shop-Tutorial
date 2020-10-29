using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;

    public TextMeshProUGUI buttonText;
    public Image skinImage;

    public bool isSkinUnlocked;

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
        IsSkinUnlocked();
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo.skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip";
        }
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {
            //equip
            FindObjectOfType<SkinManager>().EquipSkin(skinInfo);
        }
        else
        {
            //buy
            if (FindObjectOfType<PlayerMoney>().TryRemoveMoney(skinInfo.skinPrice))
            {
                
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                IsSkinUnlocked();
            }
        }
    }
}
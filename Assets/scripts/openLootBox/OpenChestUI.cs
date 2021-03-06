﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChestUI : MonoBehaviour
{
    public GameObject OpenChestUI_gm, SelectChestUI_gm, imgChest_gm, ResultChestUI_gm, TopUi,BotUI;
    Collection collection;
    public bool BronzeChest = false, SilverChest = false, GoldChest = false;

    public void Start()
    {
        collection = GameObject.Find("GlobalObject").GetComponent<Collection>();
    }

    public void SelectBronze()
    {
        ToogleUIChest();
        imgChest_gm.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("pic/Chest_02_02")[0];
        BronzeChest = true;
    }
    public void SelectSilver()
    {
        ToogleUIChest();
        imgChest_gm.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("pic/3typeschest")[1];
        SilverChest = true;
    }
    public void SelectGold()
    {
        ToogleUIChest();
        imgChest_gm.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("pic/3typeschest")[2];
        GoldChest = true;
    }

    void ToogleUIChest()
    {
        if (SelectChestUI_gm.active)
        {
            SelectChestUI_gm.SetActive(false);
            OpenChestUI_gm.SetActive(true);
            TopUi.SetActive(false);
            BotUI.SetActive(false);
        }
        else
        {
            OpenChestUI_gm.SetActive(false);
            SelectChestUI_gm.SetActive(true);
        }
    }

    public void OpenChest()
    {
        if (collection.tickets > 0)
        {
            //getRndWeapon.GetComponent<GetRndWeapon>().glowbgAnimation();
            OpenChestUI_gm.SetActive(false);
            ResultChestUI_gm.SetActive(true);

        }
    }

    public void DefaultViews()
    {
        ResultChestUI_gm.SetActive(false);
        SelectChestUI_gm.SetActive(true);
        TopUi.SetActive(true);
        BotUI.SetActive(true);
        GameObject.Find("ImageItem").SetActive(false);
    }

}

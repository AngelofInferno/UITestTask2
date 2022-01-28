using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour
{
    [SerializeField] private GameObject pin;
    [SerializeField] private GameObject[] coins;
    [SerializeField] private string name;

    private Stage _stage;
    // Start is called before the first frame update
    void Start()
    {
        _stage = new Stage(name, Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public void TurnPin(bool state)
    {
        pin.SetActive(state);
        CanvasControl.Instance.SetUserFields(_stage.Name, _stage.CrystalBarValue, _stage.CoinBarValue, _stage.MagicPotBarValue);
    }

    public void AddCoins(int count)
    {
        for (int i = 0; i < count; i++)
        {
            coins[i].SetActive(i < count);
        }
    }

    /*public void SetUserFields(string name, float crystalBarValue, float coinBarValue, float magicPotBarValue)
    {
        name = _stage.Name;
        crystalBarValue = _stage.CrystalBarValue;
        coinBarValue = _stage.CoinBarValue;
        magicPotBarValue = _stage.MagicPotBarValue;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Stage
{
    private string name;
    private float _crystalBarValue;
    private float _coinBarValue;
    private float _magicPotBarValue;

    public Stage(string name, float crystalBarValue, float coinBarValue, float magicPotBarValue)
    {
        this.name = name;
        _crystalBarValue = crystalBarValue;
        _coinBarValue = coinBarValue;
        _magicPotBarValue = magicPotBarValue;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public float CrystalBarValue
    {
        get => _crystalBarValue;
        set => _crystalBarValue = value;
    }

    public float CoinBarValue
    {
        get => _coinBarValue;
        set => _coinBarValue = value;
    }

    public float MagicPotBarValue
    {
        get => _magicPotBarValue;
        set => _magicPotBarValue = value;
    }
}

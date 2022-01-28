using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    public static CanvasControl Instance;
    
    [SerializeField] private Button[] _buttons;

    [SerializeField] private GameObject[] _stageGameObjects;
    private List<StageControl> _stageControls;

    private GameObject _currentStageGameObject;
    private int _currentStageNumber;

    private List<GameObject> _currentCoins;

    [SerializeField] private Text userName;
    [SerializeField] private Slider _crystalBar;
    [SerializeField] private Slider _coinBar;
    [SerializeField] private Slider _magicPotBar;

    [SerializeField] private GameObject marketScreen;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _stageControls = new List<StageControl>();
        foreach (var stageGameObject in _stageGameObjects)
        {
            _stageControls.Add(stageGameObject.GetComponent<StageControl>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           _stageControls[_currentStageNumber].AddCoins(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _stageControls[_currentStageNumber].AddCoins(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _stageControls[_currentStageNumber].AddCoins(3);
        }
    }

    public void OnLevelStageClick(int buttonNumber)
    {
        Vector2 newScale;
        //if()
        if (!marketScreen.activeSelf)
        {
            marketScreen.SetActive(true);
        }
        if (_currentStageGameObject != null)
        {
            newScale = new Vector2(1f, 1f);
            _stageControls[_currentStageNumber].TurnPin(false);
            _currentStageGameObject.transform.localScale = newScale;
            
        }

        
        
        _currentStageNumber = buttonNumber;
        _currentStageGameObject = _stageGameObjects[buttonNumber];
        newScale = new Vector2(1.5f, 1.5f);
        _stageControls[buttonNumber].TurnPin(true);
       // _stageControls[buttonNumber].SetUserFields(userName.text, _crystalBar.value, _coinBar.value, _magicPotBar.value);
        _stageGameObjects[buttonNumber].transform.localScale = newScale;
        
    }

    public void SetUserFields(string uName, float crystalBarValue, float coinBarValue, float magicPotBarValue)
    {
        userName.text = uName;
        _crystalBar.value = crystalBarValue;
        _coinBar.value = coinBarValue;
        _magicPotBar.value = magicPotBarValue;
    }
}

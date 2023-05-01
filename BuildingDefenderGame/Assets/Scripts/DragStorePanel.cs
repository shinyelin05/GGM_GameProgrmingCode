using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragStorePanel : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform dragRectTransform; //움직일대상지정
    [SerializeField] private Canvas canvas;//캔버스지정

    private ResourceUI resourceUI;

    [SerializeField] public Text coinText;

    void Awake()
    {
        resourceUI= GetComponent<ResourceUI>();
    }

    void Update()
    {
        AmountCoinText();
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;//드래그
    }

    public void ToggleVisible()
    {
        gameObject.SetActive(!gameObject.activeSelf);

        if (gameObject.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    void AmountCoinText()
    {
        //coinText.text = resourceUI.resourceAmount.ToString();
        //Debug.Log($"코인 텍스트 {coinText}");
       // Debug.Log($"코인 텍스트 {resourceUI.resourceAmount.ToString()}");
    }

}

using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public int itemPrice = 10; // 아이템 가격
    private ResourceUI resourceUI; // ResourceUI 스크립트의 참조

    public Button yourButton;

    private void Awake()
    {
        resourceUI = GetComponent<ResourceUI>();

        // yourButton이라는 이름의 버튼을 찾습니다.
        yourButton = GetComponent<Button>();
       
    }

    private void Update()
    {
      
    }
    public void BuyItem()
    {
        
            Debug.Log("asdf");
            int currentAmount = resourceUI.resourceAmount; // 현재 자원의 수량 가져오기
            if (currentAmount >= itemPrice)
            {
                // 아이템 구매 가능
                int remainingAmount = currentAmount - itemPrice; // 구매 후 남은 자원의 수량 계산
                resourceUI.resourceAmount = remainingAmount; // 남은 자원의 수량 업데이트

                Debug.Log("Item purchased! Remaining amount: " + remainingAmount);
            }
            else
            {
                Debug.Log("Insufficient resources to buy the item!");
            }
        
    }

}
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public int itemPrice = 10; // ������ ����
    private ResourceUI resourceUI; // ResourceUI ��ũ��Ʈ�� ����

    public Button yourButton;

    private void Awake()
    {
        resourceUI = GetComponent<ResourceUI>();

        // yourButton�̶�� �̸��� ��ư�� ã���ϴ�.
        yourButton = GetComponent<Button>();
       
    }

    private void Update()
    {
      
    }
    public void BuyItem()
    {
        
            Debug.Log("asdf");
            int currentAmount = resourceUI.resourceAmount; // ���� �ڿ��� ���� ��������
            if (currentAmount >= itemPrice)
            {
                // ������ ���� ����
                int remainingAmount = currentAmount - itemPrice; // ���� �� ���� �ڿ��� ���� ���
                resourceUI.resourceAmount = remainingAmount; // ���� �ڿ��� ���� ������Ʈ

                Debug.Log("Item purchased! Remaining amount: " + remainingAmount);
            }
            else
            {
                Debug.Log("Insufficient resources to buy the item!");
            }
        
    }

}
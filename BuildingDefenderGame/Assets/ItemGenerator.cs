using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public Button generateButton; // ���� ��ư
    public GameObject[] itemPrefabs; // ������ ������ �迭

    public GameObject circle;


    public float timer; // Ÿ�̸� ����

    public MonoBehaviour targetScript;

    public Text yourText;

    private bool canPressButton = true;

    private int clickCount = 0;
    private int maxClickCount = 5;

    public Text randText;

    private void Start()
    {
        randText.text = "�̱�!, 5�� �� �̱� ��� Ƚ���� : " + clickCount;
        yourText.gameObject.SetActive(false);
        generateButton.onClick.AddListener(GenerateItems);

        //UpdateButtonInteractable();
    }

    private void Update()
    {

        timer -= Time.deltaTime; // Ÿ�̸� ����

        if (timer <= 0f)
        {
            Time.timeScale = 1f;
            circle.SetActive(false); // Ÿ�̸� ���� �� ���� ������Ʈ�� ��Ȱ��ȭ
            targetScript.enabled = false;
            yourText.gameObject.SetActive(false);
        }

        if (Time.time >= 10f)
        {
            canPressButton = true;
           // UpdateButtonInteractable();
            TimeReset();
        }

        if (clickCount == 5)
        {
            randText.text = "�̱� ��� ���� Ƚ���� �����Ͽ����ϴ�.";
        }

    }

    private void GenerateItems()
    {

        
        int randomIndex = Random.Range(0, itemPrefabs.Length); // ������ �ε��� ����
 
        yourText.gameObject.SetActive(true);

       // OnButtonClick();

        clickCount++;

        // ��ư ���� �ڵ�
        Debug.Log(clickCount);

        // ��ư Ŭ�� �� ��ư ���� ������Ʈ
        UpdateButtonInteractable2();

        if (randomIndex == 0)
        {
            circle.gameObject.SetActive(true);
            timer = 10f; // Ÿ�̸� �ʱ�ȭ
            ChangeText("10�� ���� ��ȣ���� Ȱ��ȭ�˴ϴ�!");

        }
        else if (randomIndex == 1)
        {
            targetScript.enabled = true;
            timer = 10f;
            ChangeText("���콺 Ŭ������ �Ѿ� ������ �����մϴ�!");

        }
        else if (randomIndex == 2)
        {
            Time.timeScale= 5f;
            circle.gameObject.SetActive(true);
            timer = 50f; // Ÿ�̸� �ʱ�ȭ
            ChangeText("����� ������ 10�� ���� ��ȣ���� Ȱ��ȭ�˴ϴ�!");

        }



    }

    void ChangeText(string newText)
    {
        yourText.text = newText;
    }


    //// ��ư Ŭ�� �� ����� �Լ�
    //public void OnButtonClick()
    //{
    //    if (canPressButton)
    //    {
    //        // ��ư ���� �ڵ�
    //        Debug.Log("Button Clicked!");

    //        // ��ư Ŭ�� �� ��ư ���� ������Ʈ
    //        canPressButton = false;
    //        UpdateButtonInteractable();
    //    }
    //}

    //// ��ư ���¸� ������Ʈ�ϴ� �Լ�
    //void UpdateButtonInteractable()
    //{
    //    generateButton.interactable = canPressButton;
    //}

    // �ð� ����
    void TimeReset()
    {
    }
    void UpdateButtonInteractable2()
    {
        

        generateButton.interactable = clickCount < maxClickCount;
        randText.text = "5�� �� �̱� ��� Ƚ���� : " + clickCount;

      
       
    }
}


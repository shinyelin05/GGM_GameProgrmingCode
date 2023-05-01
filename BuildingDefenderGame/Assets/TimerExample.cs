using UnityEngine;
using UnityEngine.UI;

public class TimerExample : MonoBehaviour
{
    public Text timerText;
    private float timer;
    private bool isTimerRunning;

    void Start()
    {
        // Ÿ�̸� �ؽ�Ʈ�� ã���ϴ�.
        timerText = GetComponent<Text>();

        // Ÿ�̸� �ʱ�ȭ
        timer = 0f;
        isTimerRunning = false;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // Ÿ�̸Ӹ� ������Ʈ�ϰ� �ؽ�Ʈ�� ����մϴ�.
            timer += Time.deltaTime;
            timerText.text = FormatTime(timer);
        }
    }

    // Ÿ�̸Ӹ� �����մϴ�.
    public void StartTimer()
    {
        isTimerRunning = true;
    }

    // Ÿ�̸Ӹ� ����ϴ�.
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    // Ÿ�̸Ӹ� �ʱ�ȭ�մϴ�.
    public void ResetTimer()
    {
        timer = 0f;
        timerText.text = FormatTime(timer);
    }

    // �ð��� �����Ͽ� ���ڿ��� ��ȯ�մϴ�.
    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 100f) % 100f);

        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}

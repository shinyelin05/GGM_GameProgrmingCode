using UnityEngine;

public class BallRolling : MonoBehaviour
{
    public float speed = 3f; // ���� �ӵ�
    public Transform buildingTransform; // ������ ��ġ

    private Rigidbody2D rigidbody2d;
    private Transform targetTransform;

    private float lookForTargetTimer;
    private float lookForTargetTimerMax = .2f;

    private HealthSystem healthSystem;


    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        // ���� �ʱ� ��ġ�� �����ϰ� ����
        transform.position = new Vector2(Random.Range(-42f, 42f), 25f);

        rigidbody2d = GetComponent<Rigidbody2D>();
        targetTransform = BuildingManager.Instance.GetHQBuilding()?.transform;
        lookForTargetTimer = Random.Range(0f, lookForTargetTimerMax);
        healthSystem = GetComponent<HealthSystem>();
       // healthSystem.OnDamaged += HealthSystem_OnDamaged;
    }

    private void FixedUpdate()
    {
        // ������ ��ġ�� ���ϴ� ���� ���� ���
        Vector2 direction = (buildingTransform.position - transform.position).normalized;

        rigidbody2d.velocity = direction * speed;
    }


    private void HealthSystem_OnDamaged(object sender, System.EventArgs e)
    {
        CinemachineShake.Instance.ShakeCamera(5f, .1f);
        ChromaticAberrationEffect.Instance.SetWeight(.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        FlashlightEffect();
    }

    public SpriteRenderer flashlightSprite; // ���� ��������Ʈ
    public float flashlightRadius = 5f; // ������ ������

    void FlashlightEffect()
    {
        flashlightSprite.transform.position = new Vector3(0,0,0);
       
        flashlightSprite.gameObject.SetActive(true);

    }
}

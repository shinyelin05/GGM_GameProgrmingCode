using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public float radius = 5f; // ���� ������

    void Update()
    {
       if ( Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // z ���� 0���� �����Ͽ� 2D ���������� ��ġ�� �����մϴ�.

            // ���콺 Ŭ�� ��ġ�� �߽����� �ϴ� �� �׸���
           // DrawCircle(mousePosition, radius);

            // �� �ȿ� �ִ� �Ѿ� ����
            DestroyBulletsInCircle(mousePosition, radius);
        }
    }

    //private void DrawCircle(Vector3 center, float radius)
    //{
    //    int segments = 360; // ���� �ٻ��ϱ� ���� ���׸�Ʈ ��
    //    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
    //    lineRenderer.startWidth = 0.1f;
    //    lineRenderer.endWidth = 0.1f;
    //    lineRenderer.positionCount = segments + 1;
    //    lineRenderer.useWorldSpace = false;

    //    float x;
    //    float y;
    //    float z = 0f;

    //    float angle = 20f;

    //    for (int i = 0; i <= segments; i++)
    //    {
    //        x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
    //        y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

    //        lineRenderer.SetPosition(i, new Vector3(x, y, z) + center);

    //        angle += (360f / segments);
    //    }
    //    Destroy(lineRenderer);
    //}

    private void DestroyBulletsInCircle(Vector3 center, float radius)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(center, radius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Bullet"))
            {
                Destroy(collider.gameObject);
            }
        }
    }

}

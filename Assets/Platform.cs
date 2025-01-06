using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float move_distance = 15.0f; // ���� �ִ��̵���
    float moved_distance = 0.0f; // move_distance ��ŭ ������ ���� �ٽ� 0���� �ٲٰ� �ٽ� move_distance��ŭ �������� ���� üũ�ϱ� ���� ����
    Vector2 move_dir = Vector2.right;
    public float speed = 0.5f;

    void Update()
    {
        // �����̷��� ���� ���Ϳ� �ӷ°��� �����ָ� �̹� Frame�� �̵��� �Ÿ��� ������ ����
        // ��� ����� transform.position ���� ��ġ�� �����ָ� �̵� �� ���� ��ġ ���� new_pos �� ����ȴ�.
        Vector2 new_pos = (Vector2)transform.position + (move_dir * speed);
        transform.position = new_pos;
        moved_distance += 0.05f;

        if(moved_distance >= move_distance)
        {
            moved_distance = 0.0f;
            if(move_dir == Vector2.right)
            {
                move_dir = Vector2.left;
            }
            else if(move_dir == Vector2.left)
            {
                move_dir = Vector2.right;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 velocity;
    public ProjectileController projectileController;

    public int Player_Hp = 50;
    public void Damanged(int Damage)
    {
        Player_Hp -= Damage;

        if (Player_Hp < 0)
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        viewCamera = Camera.main;

    }



    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }

        //��ǻ�� ȭ�� 2D�� ���콺 ��ǥ���� ī�޶� ����� �� 3D ���������� ���콺 ��ġ ���� �������� ���ؼ�
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        //�÷��̾ ������ Ÿ�� ����Ʈ
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //�÷��̾� �Ǻ��� ������� �ϴ� ��ǥ�� ����
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class con : MonoBehaviour
{
    new public Rigidbody2D rigidbody;
    public List<Transform> t1;
    public int indx;
    public float smoothTime;
    public float maxspeed;
    public float speed = 5f;
    public bool smooth;
    public bool step;
    public bool fixedUpdate;
    public Vector2 velocity;



    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        // ��ȡ��������
        float moveX = Input.GetAxis("Horizontal"); // ���Ҽ�ͷ��
        float moveY = Input.GetAxis("Vertical");   // ���¼�ͷ��

        // �����ƶ�����
        Vector2 movement = new Vector2(moveX, moveY);

        // ʹ��Rigidbody2D��MovePosition�����ƶ���ɫ
        rigidbody.MovePosition(rigidbody.position + movement * speed * Time.fixedDeltaTime);

        //if (fixedUpdate)
        //{
        //    var position = MoveTovard(rigidbody.position, Time.fixedDeltaTime);
        //    rigidbody.MovePosition(position);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (!fixedUpdate)
        //{
        //    transform.position = MoveTovard(transform.position, Time.deltaTime);
        //}
        //if (transform.position == t1[indx].position)
        //{
        //    indx = ++indx % t1.Count;
        //}
    }

    private Vector2 MoveTovard(Vector2 position, float deltaTime)
    {
        Vector2 res;
        if (smooth)
        {
            res = Vector2.SmoothDamp(position, t1[indx].position, ref velocity, smoothTime, maxspeed, deltaTime);
        }
        else
        {
            res = Vector2.MoveTowards(position, t1[indx].position, speed * deltaTime);
            //var direction = (Vector2)((Vector2)t1[indx].position - position).normalized.RoundToInt();
            //res = (position + direction * speed * deltaTime);
        }
        if (step)
        {
        }
        return res;

    }
}

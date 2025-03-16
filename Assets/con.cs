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
        // 获取键盘输入
        float moveX = Input.GetAxis("Horizontal"); // 左右箭头键
        float moveY = Input.GetAxis("Vertical");   // 上下箭头键

        // 计算移动方向
        Vector2 movement = new Vector2(moveX, moveY);

        // 使用Rigidbody2D的MovePosition方法移动角色
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

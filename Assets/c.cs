using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    public Camera cam;
    public GameObject unit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (unit == null) return;
        Vector3 velocity = Vector2.zero;
        // ����Ŀ��λ��
        Vector2 targetPosition = unit.transform.position;
        Vector2 mainCameraPosition = cam.transform.position;
        if (targetPosition != mainCameraPosition)
        {
            // ƽ����ֵ��Ŀ��λ��
            //cam.transform.position = targetPosition;
        }
    }
}

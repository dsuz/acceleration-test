using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerationController : MonoBehaviour
{
    public float m_speed = 5.0f;
    public Text m_text;

    void Update()
    {
        var dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        dir.y = Input.acceleration.y;

        if (m_text)
            m_text.text = "X: " + dir.x.ToString("F2") + "\r\nY: " + dir.y.ToString("F2") ;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Translate(dir * m_speed);
    }
}
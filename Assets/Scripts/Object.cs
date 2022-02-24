using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Object : MonoBehaviour
{
    public float speed
    {
        get { return m_speed; }
        private set { }
    }

    private float m_speed;

    private float m_elapsedTime;
    protected abstract void Move();

    private void Update()
    {
        m_elapsedTime += Time.deltaTime;

        m_speed = Mathf.Sin(m_elapsedTime);

        Move();
    }
}

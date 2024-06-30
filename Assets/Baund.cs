using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボールを制御するコンポーネント。ボールのオブジェクトに追加して使う。
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    [SerializeField] float m_movePower = 15f;

    Rigidbody2D m_rb = default;
    /// <summary>ボールが最初に動く方向</summary>
    [SerializeField] Vector2 m_powerDirection = Vector2.up + Vector2.right;
    /// <summary>ボールを最初に動かす力の大きさ</summary>
    [SerializeField] float m_powerScale = 5f;
    Rigidbody2D m_rb2d;

    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        // ボールを動かす
        Push();
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_rb.AddForce(Vector2.up * m_movePower, ForceMode2D.Force);
    }

    /// <summary>
    /// ボールに力を加える
    /// </summary>
    public void Push()
    {
        m_rb2d.AddForce(m_powerDirection.normalized * m_powerScale, ForceMode2D.Impulse);
    }
}
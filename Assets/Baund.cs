using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �{�[���𐧌䂷��R���|�[�l���g�B�{�[���̃I�u�W�F�N�g�ɒǉ����Ďg���B
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    [SerializeField] float m_movePower = 15f;

    Rigidbody2D m_rb = default;
    /// <summary>�{�[�����ŏ��ɓ�������</summary>
    [SerializeField] Vector2 m_powerDirection = Vector2.up + Vector2.right;
    /// <summary>�{�[�����ŏ��ɓ������͂̑傫��</summary>
    [SerializeField] float m_powerScale = 5f;
    Rigidbody2D m_rb2d;

    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        // �{�[���𓮂���
        Push();
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_rb.AddForce(Vector2.up * m_movePower, ForceMode2D.Force);
    }

    /// <summary>
    /// �{�[���ɗ͂�������
    /// </summary>
    public void Push()
    {
        m_rb2d.AddForce(m_powerDirection.normalized * m_powerScale, ForceMode2D.Impulse);
    }
}
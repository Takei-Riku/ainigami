using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedGameObject2D : MonoBehaviour
{
    /// <summary>�X�R�A�}�l�[�W���[</summary>
    GameObject m_scoreManager;
    GameObject clickedGameObject;//�N���b�N���ꂽ�Q�[���I�u�W�F�N�g��������ϐ�
    private void Start()
    {
        m_scoreManager = GameObject.Find("GameManager");    // GameManager ��T���Ď���Ă���
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                Debug.Log(clickedGameObject.name);//�Q�[���I�u�W�F�N�g�̖��O���o��
                Destroy(clickedGameObject);//�Q�[���I�u�W�F�N�g��j��
                if (m_scoreManager != null)
                {
                    ScoreManager sm = m_scoreManager.GetComponent<ScoreManager>();
                    sm.AddScore(1);
                    sm.BlockBreakCounter += 1;
                    Debug.Log(clickedGameObject.name);
                }
            }

        }
    }
}
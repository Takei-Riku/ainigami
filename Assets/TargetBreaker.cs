using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedGameObject2D : MonoBehaviour
{
    /// <summary>スコアマネージャー</summary>
    GameObject m_scoreManager;
    GameObject clickedGameObject;//クリックされたゲームオブジェクトを代入する変数
    private void Start()
    {
        m_scoreManager = GameObject.Find("GameManager");    // GameManager を探して取ってくる
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
                Debug.Log(clickedGameObject.name);//ゲームオブジェクトの名前を出力
                Destroy(clickedGameObject);//ゲームオブジェクトを破壊
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
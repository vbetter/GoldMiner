using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HookState
{
    Idle,
    Throw,
    Back
}

public class Hook : MonoBehaviour {

    Animator m_animator;

    bool m_isMove = false;
    float m_timer = 0;

    HookState m_HookState = HookState.Idle;

    [SerializeField]
    Transform m_posLine;

    Vector3 m_origin= new Vector3 (-0.184f, 4.5f, -1f);

    LineRenderer m_LineRenderer;

    [SerializeField]
    Transform m_ItemParent;

    // Use this for initialization
    void Start () {
        m_animator = GetComponent<Animator>();

        m_LineRenderer = GetComponent<LineRenderer>();
    }
	


	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Hook Throw");
            m_timer = 0;
            m_animator.speed = 0;
            m_animator.enabled = false;

            m_isMove = true;
            m_HookState = HookState.Throw;

        }

        if(m_isMove)
        {
            m_timer += Time.deltaTime;

            if(m_timer>3f)
            {
                m_HookState = HookState.Back;
            }
        }

        switch (m_HookState)
        {
            case HookState.Idle:
                break;
            case HookState.Throw:
                transform.Translate(Vector3.left * Time.deltaTime);
                break;
            case HookState.Back:
                if (Vector3.Distance(transform.localPosition, m_origin) <= 0.1f)
                {
                    m_HookState = HookState.Idle;
                    m_isMove = false;
                    m_animator.speed = 1;
                    m_animator.enabled = true;
                }

                transform.Translate(Vector3.right * Time.deltaTime);
                break;
            default:
                break;
        }


        m_LineRenderer.SetPosition(0, m_origin);
        m_LineRenderer.SetPosition(1, m_posLine.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1");

        BaseItem baseItem = collision.GetComponent<BaseItem>();
        if(baseItem!=null)
        {
            if(baseItem.ItemConfig.isCatch)
            {
                dragItem(collision.gameObject);
                m_HookState = HookState.Back;
            }
        }
    }

    void dragItem(GameObject go)
    {
        BoxCollider2D box = go.GetComponent<BoxCollider2D>();
        go.transform.parent = m_ItemParent;
        go.transform.localPosition = new Vector3(0f- box.size.y/2f, 0f, 0f);
    }

    
}

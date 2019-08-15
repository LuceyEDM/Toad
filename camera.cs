using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform m_playerTransform;
    public Vector3 targetPos;
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        m_playerTransform = GameObject.Find("player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(m_playerTransform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        targetPos = new Vector3(m_playerTransform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }
}

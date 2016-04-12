using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    public GameObject Player;
    public GameObject Parent;

	// Use this for initialization
	void Start () {
        transform.position = Player.transform.position;
        transform.rotation = Quaternion.Euler(0, Player.transform.rotation.eulerAngles.y + 90, 90);
	}
	
	// Update is called once per frame
	void Update () {
        if (!Cursor.visible)
        {
            transform.Translate(Vector3.up * (5 * Time.deltaTime));
            OutsideScreen();
        }
	}

    void OutsideScreen()
    {
        if (Parent.transform.name == "Capsule(Clone)")
        {
            if (transform.position.x > 5 || transform.position.x < -5)
                Destroy(Parent);
            if (transform.position.z > 5 || transform.position.z < -5)
                Destroy(Parent);
        }
    }

    void OnTriggerEnter (Collider enemy)
    {
        if (enemy.gameObject.name == "Enemy(Clone)")
            enemy.gameObject.GetComponent<EnemyScript>().m_HP--;
    }

}

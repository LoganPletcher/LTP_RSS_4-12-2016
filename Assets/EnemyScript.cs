using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    float Updates;
    float TBP = 0;
    public int m_HP = 10;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        if (this.name == "Enemy(Clone)")
            transform.position = new Vector3(Random.Range(0, 4.75F), .25F, Random.Range(-4.75F, 4.75F));
	}
	
	// Update is called once per frame
	void Update () {
        if (!Cursor.visible)
        {
            if (this.name == "Enemy(Clone)")
            {
                transform.LookAt(Player.transform);
                transform.Translate(Vector3.forward * .5F * Time.deltaTime);
                Death();
            }
        }
	}

    void Death()
    {
        if (m_HP <= 0)
        {
            Player.GetComponent<PlayerScript>().Score++;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay(Collider Player)
    {
        Updates += 1 * Time.deltaTime;
        if (Player.gameObject.name == "Player" && Updates - TBP > 1)
        {
            this.Player.GetComponent<PlayerScript>().m_HP--;
            TBP = Updates;
        }
    }

}

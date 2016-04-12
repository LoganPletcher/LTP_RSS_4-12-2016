using UnityEngine;
using System.Collections;

public class EnemySpawning : MonoBehaviour {

    public GameObject Enemy;
    float Updates;
    float TBP = 0;
    float SpwnSpeed = 10;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!Cursor.visible)
        {
            Updates += 1 * Time.deltaTime;
            if (Updates - TBP > SpwnSpeed)
            {
                if (SpwnSpeed > 1)
                    SpwnSpeed -= Time.deltaTime;
                TBP = Updates;
                Instantiate(Enemy);
            }
        }
    }
}

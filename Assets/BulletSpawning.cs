using UnityEngine;
using System.Collections;

public class BulletSpawning : MonoBehaviour {

    public GameObject bullet;
    float Updates;
    float TBP = 0;
    bool shooting;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (!Cursor.visible)
        {
            if (Input.GetMouseButtonDown(0))
                shooting = true;
            if (Input.GetMouseButtonUp(0))
                shooting = false;
            Updates += 1 * Time.deltaTime;
            if (shooting && Updates - TBP > .1)
            {
                TBP = Updates;
                Instantiate(bullet);
            }
        }
	}
}

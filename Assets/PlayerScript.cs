using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public int m_HP = 100;
    public int Score = 0;
    public Text ScoreT;
    public Image HealthBar;
    bool Forward, Backward, Left, Right;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        HealthBar.rectTransform.sizeDelta = new Vector2(m_HP * 5, 10);
        ScoreT.text = "Score: " + Score;
        if (!Cursor.visible)
        {
            Death();
            float yAxis = transform.rotation.eulerAngles.y + (100.0F * Input.GetAxis("Mouse X") * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, yAxis, 0);
            Movement();
        }

    }

    void Movement()
    {
        if (Input.GetKeyDown("w"))
            Forward = true;
        if (Input.GetKeyUp("w"))
            Forward = false;
        if (Input.GetKeyDown("s"))
            Backward = true;
        if (Input.GetKeyUp("s"))
            Backward = false;
        if (Input.GetKeyDown("a"))
            Left = true;
        if (Input.GetKeyUp("a"))
            Left = false;
        if (Input.GetKeyDown("d"))
            Right = true;
        if (Input.GetKeyUp("d"))
            Right = false;
        if (Forward)
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        if (Backward)
            transform.Translate(Vector3.back * 2 * Time.deltaTime);
        if (Left)
            transform.Translate(Vector3.left * 2 * Time.deltaTime);
        if (Right)
            transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }

    void Death()
    {
        if (m_HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}

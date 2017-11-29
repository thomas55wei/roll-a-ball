using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    private int count;
    public Text countText;
    public Text winText;

    private void Start()
    {
        count = 0;
        winText.text = "";
        this.SetCountText();
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        this.GetComponent<Rigidbody>().AddForce(new Vector3(moveHorizontal, 0, moveVertical)*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            this.SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(this.count>=7)
        {
            winText.text = "You Win!";
        }
    }
}

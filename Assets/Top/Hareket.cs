using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Buraya da bi şeyler gelecek

public class Hareket : MonoBehaviour
{
    public Vector3 hareket;
    public Vector3 ofset;
    public GameObject obje1;
    public GameObject obje2;
    //text objelerini buralarda olacak
    public float guc;
    public GameObject score;
    public GameObject kamera;
    public int skor;
    public bool yerde;
    public float yokoltime;
    public bool yokol;
    void Start()
    {
        yerde = true;
    }

    void Update()
    {
        Getinput();
        kamera.transform.position = transform.position + ofset;
        obje1.GetComponent<Text>().text = "" + hareket.x;
        obje2.GetComponent<Text>().text = "" + hareket.z;
        score.GetComponent<Text>().text = "" + skor;
        if (Input.GetKeyDown(KeyCode.Space) && yerde == true)
        {
            yerde = false;
            hareket += new Vector3(0, guc, 0);
        }
        GetComponent<Rigidbody>().AddForce(hareket);
        transform.forward = new Vector3(-hareket.z, -90, hareket.x);
       
        //!!!!!!!!!!!!!KODU BURAYA YAZIN!!!!!!!!!!!!!!!!!
    }

    private void Getinput()
    {
        hareket = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Yer")
        {
            yerde = true;
        }
        if (other.gameObject.tag == "Ha")
        {
            transform.localScale *= 1.05f;
            Destroy(other.gameObject);
            skor = skor + 5;
        }
        if (other.gameObject.tag == "ha20")
        {
            transform.localScale *= 1.05f;
            Destroy(other.gameObject);
            skor = skor + 20;
        }


        if (other.gameObject.tag == "wooow")
        {
            transform.localScale *= 1.05f;
            Destroy(other.gameObject);
            skor = skor + 100;
            GetComponent<Animator>().SetTrigger("Pat");

        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "uuuuuç")
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * guc * 5.9f);
        }
    }
}


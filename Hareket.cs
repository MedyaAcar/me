using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Buraya da bi şeyler gelecek

public class Hareket : MonoBehaviour
{
    public Vector3 hareket;
    public GameObject obje1;
    public GameObject obje2;
    //text objelerini buralarda olacak
    public float guc;

    public bool yerde;
    
    void Start()
    {
        yerde = true;
    }

    void Update()
    {
        Getinput();
        obje1.GetComponent<Text>().text = "" + hareket.x;
        obje2.GetComponent<Text>().text = "" + hareket.z;
        if (Input.GetKeyDown(KeyCode.Space) & yerde == true)
        {
            yerde = false;
            hareket += new Vector3(0, guc, 0);
        }
        GetComponent<Rigidbody>().AddForce(hareket);
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
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleScript : MonoBehaviour
{

  public GameObject punch;
  public GameObject jab;
  // Start is called before the first frame update
  void Start()
    {
    punch.GetComponent<Animation>().Stop();
    jab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PunchAction()
    {
      jab.SetActive(false);
      punch.SetActive(true);
      punch.GetComponent<Animation>().Play();
      
    }

    public void JabAction() {
      punch.SetActive(false);
      jab.SetActive(true);
      jab.GetComponent<Animation>().Play();    }
}

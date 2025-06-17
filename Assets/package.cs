using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class package : MonoBehaviour
{
    public GameObject boxımages;
    bool PaketAlındıMı;

    public GameObject packageEMRE;
    void Start()
    {
        boxımages.SetActive(false);
        packageEMRE.SetActive(true);
        PaketAlındıMı = false;
    }
 private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("package"))
        {
            boxımages.SetActive(true);
            packageEMRE.SetActive(false);
            PaketAlındıMı = true;
        }
    }

}

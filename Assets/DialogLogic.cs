using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogLogic : MonoBehaviour
{
    public string popUp;
    // Update is called once per frame
    void Update()
    {
        PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
        pop.PopUp(popUp);
    }
}

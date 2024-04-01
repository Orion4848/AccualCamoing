using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodScript : MonoBehaviour
{
    public playerItems items;
    string tag = gameObject.tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision target) {
        items.itemsHM.Add(tag, 1);
        if (items.itemsHM.ContainsKey(tag)) {
            items.itemsHM[tag] = items.itemsHM[tag] + 1;
        } else {
            items.itemsHM.Add(tag, 1);
        }
    }
}

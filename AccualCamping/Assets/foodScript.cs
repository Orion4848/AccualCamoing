using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodScript : MonoBehaviour
{
    [SerializeField] playerItems items;
    //string tag = gameObject.tag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision target) {
        if (target.gameObject.tag == "Player") {
            if (items.itemsHM.ContainsKey(gameObject.tag)) {
                items.itemsHM[gameObject.tag] = items.itemsHM[gameObject.tag] + 1;
            } else {
                items.itemsHM.Add(gameObject.tag, 1);
            }
            foreach (KeyValuePair<string, int> pair in items.itemsHM) {
                print(pair.Key + ", " + pair.Value);
            }
            Destroy(gameObject);
        }
    }
}

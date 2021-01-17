using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getinfo : MonoBehaviour
{
    public string groundtag;
    public string groundname;
    public bool isground=false;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

         if (hit.collider != null) {
            groundtag = hit.collider.tag;
            Debug.Log(hit.collider.tag);
            if(groundtag =="ground" || groundtag == "bmo"){
               isground = true;
               groundname = hit.collider.name;
               x = hit.collider.transform.position.x;
               y = hit.collider.transform.position.y;
            }
         }
      }
   }
}

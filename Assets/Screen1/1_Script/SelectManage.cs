using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManage : MonoBehaviour
{
    public Camera mainCam;
    private ImageManager ImgMang;
    //public List<Sprite> ImgList;
    public List<GameObject> imgList = new List<GameObject>();
    private List<Sprite> ImgSaveList = new List<Sprite>();
    


    void Start()
    {
       // List<Sprite> sprites = new List<Sprite>();
      // List<GameObject> btnList = new List<GameObject>();
    }
    void Update()
    {
        RayHit();
    }

    void RayHit()
    {
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos1 = mainCam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 clickPos = new Vector2(worldPos1.x, worldPos1.y);
            Collider2D clickCollider = Physics2D.OverlapPoint(clickPos);
            //Debug.Log(clickCollider.gameObject); //코드확인용
          
            if(clickCollider.gameObject.name == "Image1")
            {
                // ImgSaveList[0] = ImgMang.images[1];
                Debug.Log("True");
                for(int i =0; i<14; i++)
                {
                    
                }
            }
            if (clickCollider.gameObject.name == "Image2")
            {
                
            }
            if (clickCollider.gameObject.name == "Image3")
            {
               
            }
            if (clickCollider.gameObject.name == "Image4")
            {
                
            }
            if (clickCollider.gameObject.name == "Image5")
            {
               
            }
            //Debug.Log(ImgSaveList[0]);
        }
    }

  
}

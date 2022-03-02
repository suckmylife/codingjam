using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    private SpriteRenderer imagerenderer;
    public List<Sprite> images;

    void Start()
    {
        imagerenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }
    public void DieDay()
    {
        imagerenderer.sprite = images[0];
    }
    public void Sky()
    {
        imagerenderer.sprite = images[1];
    }

    public void Lookup()
    {
        imagerenderer.sprite = images[2];
    }

    public void dot()
    {
        imagerenderer.sprite = images[3];
    }

    public void Shy()
    {
        imagerenderer.sprite = images[4];
    }

    public void Leaf()
    {
        imagerenderer.sprite = images[5];
    }

    public void wind()
    {
        imagerenderer.sprite = images[6];
    }

    public void Pain()
    {
        imagerenderer.sprite = images[7];
    }



    public void Star()
    {
        imagerenderer.sprite = images[8];
    }

    public void Sing()
    {
        imagerenderer.sprite = images[9];
    }


    public void Die_ing()
    {
        imagerenderer.sprite = images[10];
    }

    public void Love()
    {
        imagerenderer.sprite = images[11];
    }

    public void Gill()
    {
        imagerenderer.sprite = images[12];
    }

    public void Walk()
    {
        imagerenderer.sprite = images[13];
    }
    

   
    public void OnclickEv()
    {

    }
}

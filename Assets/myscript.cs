using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myscript : MonoBehaviour
{
    //public Button EzgininButonu;


    int sayi = 0;
    public void konsolaYazdir(){
    sayi = sayi + 1;
    Debug.Log("Düşmana ateş edildi." + sayi);

        }
}

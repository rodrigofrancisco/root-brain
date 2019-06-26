using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Memorama : MonoBehaviour {
    public List<Button> pieza;
    public List<Sprite> imagen;
    private List<Button> seleccion;
    private List<Sprite> imagenCopia;
    private bool esperando;

    void Start(){
        //Se asigna el comportamiento a cada pieza.
        foreach (var elemento in pieza) {
            elemento.onClick.AddListener(delegate { Clic(elemento); });
        }
        Reset();
    }
    
    void Update() {
        if (seleccion.Count == 2 && !esperando) {            
            if ((seleccion[0] != seleccion[1]) && (seleccion[0].image.sprite == seleccion[1].image.sprite)) {
                Invoke("Correcto", 0.5f);
                esperando = true;                
            }
            else {
                Invoke("Incorrecto", 0.5f);
                esperando = true;
            }
        }
    }

    void Clic(Button pieza) {
        seleccion.Add(pieza);
        pieza.image.color = new Color(1, 1, 1, 1);        
    }

    void Incorrecto() {
        seleccion[0].image.color = new Color(0, 0, 0, 0);
        seleccion[1].image.color = new Color(0, 0, 0, 0);
        seleccion.Clear();
        esperando = false;
    }

    void Correcto() {
        seleccion[0].gameObject.SetActive(false);
        seleccion[1].gameObject.SetActive(false);
        seleccion.Clear();
        Ganar();
        esperando = false;        
    }

    public void Ganar() {
        bool ganado = true;

        foreach (var elemento in pieza) {
            if (elemento.IsActive()) {
                ganado = false;
            }
        }

        if (ganado) {
            foreach (var elemento in pieza) {
                elemento.gameObject.SetActive(true);
            }
            SceneManager.LoadScene(0);
            Reset();
        }        
    }

    void Reset() {
        seleccion = new List<Button>(0);
        esperando = false;
        //Se ponen aleatoriamente las imágenes a las piezas.
        imagenCopia = new List<Sprite>(imagen);
        int i;
        foreach (var elemento in pieza) {
            i = Random.Range(0, imagenCopia.Count);
            elemento.GetComponent<Image>().sprite = imagenCopia[i];
            elemento.image.color = new Color(0, 0, 0, 0);
            imagenCopia.RemoveAt(i);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class ButtonBehaviour : MonoBehaviour
{
    int n;
    public Text myText;
    public Slider mySlider;
    void Update()
    {
        myText.text = "Current Volume: " + mySlider.value;
    }
}
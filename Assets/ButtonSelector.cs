using UnityEngine;

public class ButtonSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] speakers;
    private GameObject selectedspeaker;
    void Start()
    {
        selectedspeaker = speakers[0];
        selectedspeaker.SetActive(true);
    }

    // Update is called once per frame

    public void Selector( GameObject clicked)
    {
        foreach( GameObject go in speakers)
        {
            go.SetActive(false);
        }
        selectedspeaker = clicked;
        selectedspeaker.SetActive(true);
    }

    
}

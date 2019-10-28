using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class music : MonoBehaviour
{

    public Image image;
    public bool isPress = false;
    public Button button;
    public Sprite moff;
    public Sprite mon;
    // Use this for initialization
    void Start()
    {
        image = button.GetComponent<Image>();
    }

    // Update is called once per frame



    public void ChangeSprites()
    {
        isPress = !isPress;
        if (isPress == true)
        {
            image.sprite = moff;
            AudioListener.volume = 0;

        }
        else
        {
            image.sprite = mon;
            AudioListener.volume = 1;
        }
    }
}

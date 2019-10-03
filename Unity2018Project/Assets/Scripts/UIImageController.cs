using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class UIImageController : MonoBehaviour
{
    private Image img;
    void Awake()
    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(FloatDataScript data)
    {
        img.fillAmount = data.value;
    }
    
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    public UnityEvent startEvent;
        
        
    private Text textLabel;
        //make sure your text class is the variant using UnityEngine.UI;

        private void UpdateText(IntData data)
        {
            textLabel.text = data.value.ToString();
        }
        
    void Start()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}

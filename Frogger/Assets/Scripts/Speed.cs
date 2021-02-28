using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Slider slider;

    public void Awake()
    {
        slider = GameObject.FindWithTag("speed").GetComponent<Slider>();
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        Car.speed = slider.value;
    }

}

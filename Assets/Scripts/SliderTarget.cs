using UnityEngine;
using UnityEngine.UI;

public class SliderTarget : Target
{
    private Slider sliderRef;
    private void Start()
    {
        anim = GetComponent<Animator>();
        sliderRef = GetComponent<Slider>();
    }
    public void Dragged()
    {
        if (sliderRef.value >= sliderRef.maxValue)
        {
            StartCoroutine(Successful(gameObject));
            sliderRef.interactable = false;
        }
    }
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
        transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(-1.5f, 1.5f));
        transform.Rotate(0f, 0f, Random.Range(0f, 360f));
        sliderRef = GetComponent<Slider>();
        sliderRef.value = 0f;
        anim.SetBool("Active", true);
    }
}

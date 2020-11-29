using UnityEngine;
using UnityEngine.UI;

public class ButtonTarget : Target
{
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Clicked()
    {
        GetComponent<Button>().interactable = false;
        StartCoroutine(Successful(gameObject));
    }
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
        transform.position = new Vector2(Random.Range(-6.4f,6.4f), Random.Range(-1.5f, 3.3f));
        anim.SetBool("Active", true);
    }
}

using UnityEngine;

public class OsuPooler : MonoBehaviour
{
    public GameObject buttTarget;
    public GameObject sliderTarget;
    public GameObject targetGO;
    [SerializeField] private int ButtCapacity;
    [SerializeField] private int SliderCapacity;

    public void Init()
    {
        AddToPool(buttTarget, ButtCapacity);
        AddToPool(sliderTarget, SliderCapacity);
    }
    private void AddToPool(GameObject obj, int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject _newGO = Instantiate(obj, transform);
            _newGO.SetActive(false);
        }
    }
    private int Rando()
    {
        int rando = 0;
        for (int i = 0; i < 1000; i++)
        {
            rando = Random.Range(0, transform.childCount);
            if (!transform.GetChild(rando).gameObject.activeInHierarchy)
            {
                break;
            }
        }
        return rando;
    }
    public void ActivateRandom()
    {
        targetGO = transform.GetChild(Rando()).gameObject;
        targetGO.gameObject.SetActive(true);
    }
    public void Restart()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}

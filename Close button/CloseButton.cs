using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CloseButton : MonoBehaviour
{
    public GameObject target;
    public bool hide = true;
    public bool destroy;


    void Reset()
    {
        target = transform.parent.gameObject;
    }

    void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Close);
    }


    void Close()
    {
        if (hide)
            target.SetActive(false);
        if (destroy)
            Destroy(target);
    }
}

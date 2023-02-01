using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    private ScrollRect _rectScroll;
    private RectTransform _lastContent;
    void Start()
    {
        _rectScroll = GetComponent<ScrollRect>();
    }

    public void OpenPanel(GameObject content)
    {
        ColsedPanel(_rectScroll.content.gameObject);
        content.SetActive(true);
        _rectScroll.content = content.GetComponent<RectTransform>();
    }

    void ColsedPanel(GameObject content)
    {
        content.SetActive(false);
    }
}

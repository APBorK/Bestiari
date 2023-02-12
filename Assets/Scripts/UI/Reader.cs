using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
    [SerializeField] private GameObject _buttonBack;
    private Stack<GameObject> _path = new Stack<GameObject>();
    private ScrollRect _rectScroll;
    private RectTransform _lastContent;

    void Start()
    {
        _rectScroll = GetComponent<ScrollRect>();
    }

    public void OpenPanel(GameObject content)
    {
        var contentGameObject = _rectScroll.content.gameObject;
        _path.Push(contentGameObject);
        contentGameObject.SetActive(false);
        _path.Push(content);
        content.SetActive(true);
        _rectScroll.content = content.GetComponent<RectTransform>();
    }

    public void ColsedPanel()
    {
        _path.Pop().SetActive(false);
        GameObject content = _path.Pop();
        content.SetActive(true);
        _rectScroll.content = content.GetComponent<RectTransform>();
        if (_path.Count == 0)
        {
            _buttonBack.SetActive(false);
        }
    }
}

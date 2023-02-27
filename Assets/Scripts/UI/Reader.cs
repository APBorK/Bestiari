using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
    [SerializeField] private GameObject _buttonBack;
    private Stack<GameObject> _path = new Stack<GameObject>();
    private ScrollRect _rectScroll;
    private RectTransform _lastContent;

    private void Start()
    {
        _rectScroll = GetComponent<ScrollRect>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ColsedPanel();
        }
    }

    public void OpenPanel(GameObject content)
    {
        if (content.name == "Panel")
        {
            content.transform.localPosition = Vector3.zero;
        }
        var contentGameObject = _rectScroll.content.gameObject;
        _path.Push(contentGameObject);
        contentGameObject.SetActive(false);
        _path.Push(content);
        content.SetActive(true);
        _rectScroll.content = content.GetComponent<RectTransform>();
    }

    public void ColsedPanel()
    {
        if (_path.Count == 0)
        {
            Application.Quit();
        }
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

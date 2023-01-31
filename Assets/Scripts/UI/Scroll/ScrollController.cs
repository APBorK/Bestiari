using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ScrollController : MonoBehaviour
{
    private ScrollRect _rectScroll;
    private RectTransform _originalContent, _lastContent;
    void Start()
    {
        _rectScroll = GetComponent<ScrollRect>();
        _originalContent = _rectScroll.content;
    }

    public void OpenPanel(GameObject content)
    {
        ColsedPanel(_rectScroll.content.gameObject);
        content.SetActive(true);
        _rectScroll.content = content.GetComponent<RectTransform>();
    }

    public void Back()
    {
        
    }
    
    void ColsedPanel(GameObject content)
    {
        content.SetActive(false);
    }
    
    
    protected void VercticalScroll(RectTransform rectTransformConten,float maxScroll)
    {
        //_rectTransformContent.anchoredPosition = new Vector2(rectTransformConten.anchoredPosition.x,
          // Mathf.Clamp(rectTransformConten.anchoredPosition.y,_minScroll,maxScroll) );
    }
    
    void SearchMaxScroll(Button maxScroll,Button offset)
    {
        //_maxScroll = Mathf.Abs(maxScroll.transform.localPosition.y - offset.transform.localPosition.y);
    }
}

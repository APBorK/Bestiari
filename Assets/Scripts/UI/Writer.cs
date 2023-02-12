using UnityEngine;
using UnityEngine.UI;

public class Writer : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _panelExemple;
    private const int SizeText = 300;
    private string _text;
    private Text _list;
    private string _nameText;

    private void Start()
    {
        _list = _panel.GetComponentInChildren<Text>();
    }

    public void LoadText(GameObject nameText)
    {
        _nameText = nameText.name;
        _text = Resources.Load<TextAsset>("Text/" + _nameText).text;
        _list.text = _text;
        EventSystem.SendOpenText(nameText.name);
        _panel.GetComponent<RectTransform>().sizeDelta =
            new Vector2(_panel.GetComponent<RectTransform>().sizeDelta.x, _list.preferredHeight + SizeText);
    }

    //public void OpenExempleText()
    //{
    //    _panelExemple.SetActive(true);
    //    for (int i = 0; i < _panelExemple.GetComponentsInChildren<GameObject>().Length; i++)
    //    {
    //        if (_panelExemple.GetComponentsInChildren<GameObject>()[i].name == _nameText)
    //        {
    //            _panelExemple.GetComponentsInChildren<GameObject>()[i].gameObject.SetActive(true);
    //        }
    //        else
    //        {
    //            _panelExemple.GetComponentsInChildren<GameObject>()[i].gameObject.SetActive(false);
    //        }
    //    }
    //}
}

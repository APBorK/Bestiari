using UnityEngine;
using UnityEngine.UI;

public class Writer : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _panelExemple;
    private GameObject _textExemple;
    private const int SizeText = 300;
    private string _text;
    private Text _list;
    private string _nameText;

    private void Start()
    {
        _list = _panel.GetComponentInChildren<Text>();
        _textExemple = _panelExemple.GetComponentInChildren<Text>().gameObject;
    }

    public void LoadText(GameObject nameText)
    {
        _nameText = nameText.name;
        _text = Resources.Load<TextAsset>("Text/" + _nameText).text;
        _list.text = _text;
        _panel.GetComponent<RectTransform>().sizeDelta =
            new Vector2(_panel.GetComponent<RectTransform>().sizeDelta.x, _list.preferredHeight + SizeText);
        GameObject example =  Resources.Load<GameObject>("Prefabs/Text/" + _nameText);
        Destroy(_textExemple);
        _textExemple = Instantiate(example,_panelExemple.transform);
        _panelExemple.GetComponent<RectTransform>().sizeDelta =
            new Vector2(_panel.GetComponent<RectTransform>().sizeDelta.x, _textExemple.GetComponent<Text>().preferredHeight + SizeText);
    }
}

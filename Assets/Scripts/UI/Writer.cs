using UnityEngine;
using UnityEngine.UI;

public class Writer : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    private string _text;
    private Text _list;

    private void Start()
    {
        _list = _panel.GetComponentInChildren<Text>();
    }

    public void LoadText(GameObject _nameText)
    {
        _text = Resources.Load<TextAsset>("Text/" + _nameText.name).text;
        _list.text = _text;
        _panel.GetComponent<RectTransform>().sizeDelta =
            new Vector2(_panel.GetComponent<RectTransform>().sizeDelta.x, _list.preferredHeight + 200);
    }
}

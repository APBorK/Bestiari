using UnityEngine;
using UnityEngine.UI;

public class Writer : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private const int SizeText = 200;
    private string _text;
    private Text _list;

    private void Start()
    {
        _list = panel.GetComponentInChildren<Text>();
    }

    public void LoadText(GameObject nameText)
    {
        _text = Resources.Load<TextAsset>("Text/" + nameText.name).text;
        _list.text = _text;
        panel.GetComponent<RectTransform>().sizeDelta =
            new Vector2(panel.GetComponent<RectTransform>().sizeDelta.x, _list.preferredHeight + SizeText);
    }
}

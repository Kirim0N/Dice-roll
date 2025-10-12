using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private Game game;
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        button.onClick.AddListener(OnButtonClick);
        game.NeedRedraw.AddListener(Draw);
    }

    private void Draw()
    {
        scoreText.text = game.Value.ToString();
    }
    
    private void OnButtonClick()
    {
        game.RollCubes();
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private Game game;
    [SerializeField] private Button button;
    [SerializeField] private Button spawnCubeButton;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_InputField winInputField;
    [SerializeField] private TMP_InputField drawInputField;
    [SerializeField] private TMP_Text result;


    private void Awake()
    {
        button.onClick.AddListener(OnButtonClick);
        game.NeedRedraw.AddListener(Draw);
        spawnCubeButton.onClick.AddListener(SpawnCube);
        winInputField.onEndEdit.AddListener(onWinChanged);
        drawInputField.onEndEdit.AddListener(onDrawChanged);
        
    }

    private void onWinChanged(string value)
    {
        var intValue = int.Parse(value);
        game.Win = intValue;
    }
    
    private void onDrawChanged(string value)
    {
        var intValue = int.Parse(value);
        game.Draw = intValue;
    }
    
    
    private void SpawnCube()
    {
        game.SpawnCube();
    }
    
    private void Draw()
    {
        scoreText.text = game.Value.ToString();

        if (game.Value >= game.Win)
        {
            result.text = "Win";
        }
        else if (game.Value >= game.Draw)
        {
            result.text = "Draw";
        }
        else
        {
            result.text = "Lose";
        }
    }
    
    private void OnButtonClick()
    {
        game.RollCubes();
    }
}

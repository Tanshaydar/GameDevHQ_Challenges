using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Challenge_Easy_Player_Stats_Solution : MonoBehaviour
{

    [FormerlySerializedAs("a")] [Header("UI Fields")] 
    public Text PlayerNameText;
    public Text PlayerAttackLevelText;
    public Text PlayerMagicLevelText;
    public Text PlayerSmithingLevelText;
    public Text PlayerMiningLevelText;

    private Player _player;

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerNameText.text += _player.playerName;
        PlayerAttackLevelText.text += _player.attackLevel;
        PlayerMagicLevelText.text += _player.magicLevel;
        PlayerSmithingLevelText.text += _player.smithingLevel;
        PlayerMiningLevelText.text += _player.miningLevel;
    }
}

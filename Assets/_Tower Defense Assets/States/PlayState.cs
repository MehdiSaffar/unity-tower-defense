using UnityEngine;
using UnityEngine.UI;

public class PlayState : MonoBehaviour
{
    public AudioClip onWaveBegin;
    public AudioClip onSpawn;

    public Button pauseButton;
    public UI.HealthBar healthBar;
    public UI.Money money;
    public UI.WaveIndicator waveIndicator;

    private float elapsedTime = 0f;
    public float waveIndicatorAnimationDuration = 1f;
    public void Enter()
    {
        // FIXME: Change pauseButton into UIElement ?
        pauseButton.gameObject.SetActive(true);
        healthBar.isOpen = true;
        money.isOpen = true;

        pauseButton.onClick.AddListener(OnPauseClick);

        EventManager.BaseDie += OnBaseDie;

        if (GameManager.Fsm.LastState == GameManager.States.Edit) {
            waveIndicator.isOpen = true;
            elapsedTime = 0f;
        }
    }
    public void Update()
    {
        if (GameManager.Fsm.LastState == GameManager.States.Edit)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= waveIndicatorAnimationDuration)
            {
                GameManager.LevelManager.waveSpawner.StartSpawning();
                SoundManager.RandomizeFx(onWaveBegin);
            }
        }
    }
    public void Exit()
    {
        pauseButton.gameObject.SetActive(false);

        healthBar.isOpen = false;
        money.isOpen = false;
    }
    public void OnBaseDie()
    {
        GameManager.Fsm.ChangeState(GameManager.States.LevelLose);
    }
    public void OnPauseClick()
    {
        GameManager.Fsm.ChangeState(GameManager.States.Pause);
    }
}

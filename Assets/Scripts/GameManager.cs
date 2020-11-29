using UnityEngine;
using UnityEngine.Events;

public sealed class GameManager : MonoBehaviour
{
    public static bool isPlaying;
    public static UnityEvent SuccessEvent;
    public static float TIME = 2f;
    public static float CurrentTimer;
    public static int Score;
    private static readonly object instLock = new object();
    public OsuPooler PoolerRef;
    private GameManager() { }
    public static GameManager Instance;
    private void Init()
    {
        CurrentTimer = TIME;
        isPlaying = false;
        Score = 0;
        if (Instance = null)
        {
            lock (instLock)
            {
                Instance = new GameManager();
            }
        }
        if (SuccessEvent == null)
        {
            SuccessEvent = new UnityEvent();
        }
    }
    public void StartButton()
    {
        Score = 0;
        PoolerRef.Restart();
        CurrentTimer = TIME;
        PoolerRef.ActivateRandom();
        isPlaying = true;
    }
    private void Start()
    {
        this.Init();
        PoolerRef.Init();
        SuccessEvent.AddListener(PoolerRef.ActivateRandom);
        SuccessEvent.AddListener(Success);
    }
    public void Success()
    {
        CurrentTimer = TIME;
        Score++;
        Debug.Log(Score);
    }
    public void GameOver()
    {
        isPlaying = false;
        PoolerRef.Restart();
        Debug.Log("You lost");
    }
    private void Update()
    {
        if (!isPlaying){ return; } //kill update if isnt midgame
        CurrentTimer -= Time.deltaTime;
        if (CurrentTimer >= 0f)
        {
            return;
        }
        GameOver();
    }
}

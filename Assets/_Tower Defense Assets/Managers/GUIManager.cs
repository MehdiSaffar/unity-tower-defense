using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
    [HideInInspector] public static GUIManager instance = null;

    [Header("UI Elements")]
    public MainMenuUIScript _MainMenu;
    //public TowerSelectionPanelUIScript _TowerSelectionPanel;
    public Button _PlayButton;
    public Button _PauseButton;
    public HealthBarUIScript _HealthBar;
    public WaveUIScript _WaveIndicator;
    public MoneyUIScript _Money;
    public PauseUIScript _PauseMenu;
    public LevelWinUIScript _LevelWinUI;
    public LevelLoseUIScript _LevelLoseUI;
    public TowerPropertiesUIScript _TowerProperties;
    public SelectionUIScript _SelectionUI;
    public LevelSelectionUIScript _LevelSelectionUI;

    // Defining getters for quick access
    public static Button PlayButton
    {
        get
        {
            return instance._PlayButton;
        }
    }
    public static Button PauseButton
    {
        get
        {
            return instance._PauseButton;
        }
    }
    public static MainMenuUIScript MainMenu
    {
        get
        {
            return instance._MainMenu;
        }
    }
   /* public static TowerSelectionPanelUIScript TowerSelectionPanel
    {
        get
        {
            return instance._TowerSelectionPanel;
        }
    }*/
    public static HealthBarUIScript HealthBar
    {
        get
        {
            return instance._HealthBar;
        }
    }
    public static WaveUIScript WaveIndicator
    {
        get
        {
            return instance._WaveIndicator;
        }
    }
    public static MoneyUIScript Money
    {
        get
        {
            return instance._Money;
        }
    }
    public static PauseUIScript PauseMenu
    {
        get
        {
            return instance._PauseMenu;
        }
    }
    public static LevelWinUIScript LevelWinUI {
        get {
            return instance._LevelWinUI;
        }
    }
    public static LevelLoseUIScript LevelLoseUI {
        get {
            return instance._LevelLoseUI;
        }
    }
    public static LevelSelectionUIScript LevelSelectionUI
    {
        get
        {
            return instance._LevelSelectionUI;
        }
    }
    public static TowerPropertiesUIScript TowerProperties {
        get
        {
            return instance._TowerProperties;
        }
    }
    public static SelectionUIScript SelectionUI
    {
        get
        {
            return instance._SelectionUI;
        }
    }

    public void Awake() {
        // Making sure there is exactly one instance of GUIManager
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        
        // Making sure the GUIManager persists accross levels
        if (Application.isPlaying) DontDestroyOnLoad(gameObject);
    }
}

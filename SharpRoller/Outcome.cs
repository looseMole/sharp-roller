namespace SharpRoller;

public class Outcome
{
    private int _min;
    private int _max;
    private string _desc;
    private string? _goToTable;
    private int? _goToAmount;
    private bool? _ownChoice;
    
    public int Min
    {
        get => _min;
        set => _min = value;
    }

    public int Max
    {
        get => _max;
        set => _max = value;
    }

    public string Desc
    {
        get => _desc;
        set => _desc = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string? GoToTable
    {
        get => _goToTable;
        set => _goToTable = value;
    }

    public int? GoToAmount
    {
        get => _goToAmount;
        set => _goToAmount = value;
    }

    public bool? OwnChoice
    {
        get => _ownChoice;
        set => _ownChoice = value;
    }
    
    public Outcome(int min, int max, string desc)
    {
        this._min = min;
        this._max = max;
        this._desc = desc;
    }
    
    public Outcome(int min, int max, string desc, string goToTable, int goToAmount, bool ownChoice)
    {
        this._min = min;
        this._max = max;
        this._desc = desc;
        this._goToTable = goToTable;
        this._goToAmount = goToAmount;
        this._ownChoice = ownChoice;
    }
}
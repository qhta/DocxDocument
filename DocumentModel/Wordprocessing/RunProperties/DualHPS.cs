namespace DocumentModel;

/// <summary>
/// Dual HPS. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
[TypeConverter(typeof(DualHPSTypeConverter))]
public record DualHPS
{
  private readonly int? _Val, _ValCS;

  /// <summary>
  /// Value for regular script.
  /// </summary>
  public int? Val { get => _Val; }

  /// <summary>
  /// Value for complex script.
  /// </summary>
  public int? ValCS { get => _ValCS ?? _Val; }

  /// <summary>
  /// Create dual value from a string. 
  /// String can be a single value or two values separated by comma or semicolon.
  /// </summary>
  public DualHPS(string str)
  {
    var ss = str.Split(new char[] { ';' });
    if (ss.Length <= 2 )
    {
      if (int.TryParse(ss[0], out var val))
        _Val = val;
    }
    if (ss.Length == 2 )
    {
      if (int.TryParse(ss[1], out var valCS))
        _ValCS = valCS;
    }
  }

  /// <summary>
  /// Create dual value from two integer values. 
  /// </summary>
  public DualHPS(int? val, int? valCS = null)
  {
    _Val = val;
    _ValCS = valCS;
  }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator DualHPS(string val)
  {
    return new DualHPS(val);
  }

  public static implicit operator DualHPS(int val)
  {
    return new DualHPS(val);
  }

  public static implicit operator int? (DualHPS? value) => value?.Val;
  public static implicit operator DualHPS?(int? value) => value != null ? new DualHPS(value) : null;

  public override string? ToString()
  {
    var str = Val.ToString()?.ToLower();
    if (ValCS!=Val)
      str +=";"+ValCS.ToString()?.ToLower();
    return str;
  }
}
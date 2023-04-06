namespace DocumentModel;

/// <summary>
/// Dual boolean. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
[TypeConverter(typeof(DualBooleanTypeConverter))]
public record DualBoolean
{
  private readonly bool? _Val, _ValCS;

  /// <summary>
  /// Value for regular script.
  /// </summary>
  public bool? Val { get => _Val; }

  /// <summary>
  /// Value for complex script.
  /// </summary>
  public bool? ValCS { get => _ValCS; }

  /// <summary>
  /// Create dual value from a string. 
  /// String can be a single value or two values separated by comma or semicolon.
  /// </summary>
  public DualBoolean(string str)
  {
    var ss = str.Split(new char[] { ',', ';' });
    if (ss.Length <= 2 )
    {
      if (bool.TryParse(ss[0], out var val))
        _Val = val;
    }
    if (ss.Length == 2 )
    {
      if (bool.TryParse(ss[1], out var valCS))
        _ValCS = valCS;
    }
    else
      _ValCS = _Val;
  }

  /// <summary>
  /// Create dual value from two boolean values. 
  /// </summary>
  public DualBoolean(bool? val, bool? valCS = null)
  {
    _Val = val;
    _ValCS = valCS;
  }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator DualBoolean(string val)
  {
    return new DualBoolean(val);
  }

  public static implicit operator DualBoolean(bool val)
  {
    return new DualBoolean(val);
  }

  public static implicit operator bool? (DualBoolean? value) => value?.Val;
  public static implicit operator DualBoolean?(bool? value) => value != null ? new DualBoolean(value) : null;

  //public static implicit operator (bool?, bool?)? (DualBoolean? value) => (value?.Val!=null && value?.ValCS!=null) ? DualBoolean;
  //public static implicit operator DualBoolean?((bool? value, bool? valueCS)) => value != null ? new DualBoolean(value) : null;

  public override string? ToString()
  {
    var str = Val.ToString()?.ToLower();
    if (ValCS!=Val)
      str +=";"+ValCS.ToString()?.ToLower();
    return str;
  }
}
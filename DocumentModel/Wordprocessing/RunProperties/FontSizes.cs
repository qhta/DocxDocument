namespace DocumentModel;

/// <summary>
/// Dual HPS. First value is for regular script, second for complex script.
/// If second value is null, it is assumed to be the first value;
/// </summary>
[TypeConverter(typeof(FontSizesTypeConverter))]
public record FontSizes
{
  private readonly Twips? _Val, _ValCS;

  /// <summary>
  /// Value for regular script.
  /// </summary>
  public Twips? Val { get => _Val; }

  /// <summary>
  /// Value for complex script.
  /// </summary>
  public Twips? ValCS { get => _ValCS ?? _Val; }

  /// <summary>
  /// Create dual value from a string. 
  /// String can be a single value or two values separated by comma or semicolon.
  /// </summary>
  public FontSizes(string str)
  {
    var ss = str.Split(new char[] { ';' });
    if (ss.Length <= 2 )
    {
      if (ss[0]!="")
        _Val = new Twips(ss[0]);
    }
    if (ss.Length == 2 )
    {
      if (ss[1]!="")
        _ValCS = new Twips(ss[1]);
    }
  }

  /// <summary>
  /// Create dual value from two integer values. 
  /// </summary>
  public FontSizes(int? val, int? valCS = null)
  {
    _Val = val;
    _ValCS = valCS;
  }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator FontSizes(string val)
  {
    return new FontSizes(val);
  }

  public static implicit operator FontSizes(int val)
  {
    return new FontSizes(val);
  }

  public static implicit operator int? (FontSizes? value) => value?.Val;
  public static implicit operator FontSizes?(int? value) => value != null ? new FontSizes(value) : null;

  public override string? ToString()
    => ToString(null);

  public string? ToString(string? unit)
  {
    var str = (Val is not null) ? ((Twips)Val).ToString(unit) : null;
    var str2 = (ValCS is not null) ? ((Twips)ValCS).ToString(unit) : null;
    if (str2!=str)
      str +=";"+str2;
    return str;
  }
}
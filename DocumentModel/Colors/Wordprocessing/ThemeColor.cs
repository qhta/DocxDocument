namespace DocumentModel.Wordprocessing;

/// <summary>
///   Theme color class.
/// </summary>
public class ThemeColor : Color
{
  /// <summary>
  /// Default contructor.
  /// </summary>
  public ThemeColor(ThemeColorIndex index, Percent? tint, Percent? shade)
  {
    Index = index;
    Tint = tint;
    Shade = shade;
  }

  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public ThemeColorIndex Index { get; set; } = ThemeColorIndex.None;

  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public Percent? Tint { get; set; }

  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public Percent? Shade { get; set; }

  /// <summary>
  /// Gets up to four string values separated by semicolons: index, tint, shade, and value
  /// Index is a <see cref="ThemeColorIndex"/> enumeration type string.
  /// Tint and shade are percent values (ended with percent mark) preceded with "t=" and "s=" clauses.
  /// Value is "auto" or RGB value.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    var list = new List<string?>();
    list.Add(Index.ToString());
    if (Tint is not null)
      list.Add($"t={Tint}");
    if (Shade is not null)
      list.Add($"s={Shade}");
    if (Name is not null)
      list.Add($"{Name}");
    if (Value is not null)
      list.Add($"{Value}");
    return String.Join(";", list);
  }

  /// <summary>
  /// Conditional instance creation based on string.
  /// </summary>
  /// <param name="str"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public static bool TryParse(string str, out ThemeColor? value)
  {
    value = null;
    var ss = str.Split(';');
    RGB? RGB = null;
    string? name = null;
    foreach (var s in ss)
    {
      if (s.StartsWith("t="))
      {
        var s1 = s.Substring(2);
        var val = new PercentTypeConverter().ConvertFrom(s1);
        if (value != null && val is Percent percent)
          value.Tint = percent;
      }
      else
      if (s.StartsWith("s="))
      {
        var s1 = s.Substring(2);
        var val = new PercentTypeConverter().ConvertFrom(s1);
        if (value != null && val is Percent percent)
          value.Shade = percent;
      }
      else
      {
        if (s == "auto")
          name = "auto";
        else
        if (UInt32.TryParse(s, NumberStyles.HexNumber, null, out var val))
          RGB = new RGB(val);
        else
        if (Enum.TryParse<ThemeColorIndex>(s, out var index))
          value = new ThemeColor(index, null, null);
      }
    }
    if (value != null)
    {
      value.Name = name;
      value.RGB = RGB;
    }
    return value != null;
  }
}
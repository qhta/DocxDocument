using DocumentModel.Wordprocessing;

namespace DocumentModel;

/// <summary>
/// Basic color type. Value stored as an RGB object or name or "auto" string.
/// </summary>
[TypeConverter(typeof(ColorTypeConverter))]
public class Color
{
  /// <summary>
  /// Color value can be of various color types:
  /// <list type="buller">
  ///   <item>RGB - Red, Greed, Blue with byte values.</item>
  /// </list>
  /// </summary>
  private object? _Value;

  /// <summary>
  /// Initializing constructor for empty color.
  /// </summary>
  public Color() { }

  /// <summary>
  /// Initializing constructor for "auto" or RGB color.
  /// </summary>
  /// <param name="value"></param>
  public Color(string value)
  {
    if (value == "auto")
      _Value = "auto";
    if (UInt32.TryParse(value, NumberStyles.HexNumber, null, out _))
      _Value = new RGB(value);
  }

  /// <summary>
  /// Initialization constructor with RGB value.
  /// </summary>
  /// <param name="value"></param>
  public Color(RGB value)
  {
    _Value = value;
  }

  /// <summary>
  /// Initialization constructor with theme color parameters.
  /// </summary>
  /// <param name="themeColor">Enumeration of theme color value.</param>
  /// <param name="shade">Color shade value.</param>
  /// <param name="tint">Color tinte value.</param>
  public Color(ThemeColorIndex themeColor, Percent? shade, Percent? tint)
  {
    _Value = new ThemeColor(themeColor, shade, tint);
  }

  /// <summary>
  /// Empty value
  /// </summary>
  public bool IsEmpty
  {
    get => _Value == null;
  }

  /// <summary>
  /// Check if it is "auto" color
  /// </summary>
  public bool IsAuto()
  {
    return (_Value as string)== "auto";
  }

  /// <summary>
  /// Conversion from/to RGB
  /// </summary>
  public RGB? RGB
  {
    get
    {
      if (_Value is RGB rgb) 
        return rgb;
      else
        return null;
    }
    set { _Value = value; }
  }

  /// <summary>
  /// Gets "auto" or hexadecimal RGB value.
  /// </summary>
  /// <returns></returns>
  public override string? ToString()
  {
    if (IsAuto())
      return "auto";
    return _Value?.ToString();
  }
}

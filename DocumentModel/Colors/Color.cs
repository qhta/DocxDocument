using DocumentModel.Wordprocessing;

namespace DocumentModel;

/// <summary>
/// Basic color type. Contains name and RGB values.
/// </summary>
[TypeConverter(typeof(ColorTypeConverter))]
public class Color
{
  /// <summary>
  ///   Name of the color.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   RGB value of the color.
  /// </summary>
  public RGB? Value { get; set; }

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
      Name = "auto";
    if (UInt32.TryParse(value, NumberStyles.HexNumber, null, out _))
      Value = new RGB(value);
  }

  /// <summary>
  /// Initialization constructor with RGB value.
  /// </summary>
  /// <param name="value"></param>
  public Color(RGB value)
  {
    Value = value;
  }

  /// <summary>
  /// Empty value
  /// </summary>
  public bool IsEmpty
  {
    get => Value == null;
  }

  /// <summary>
  /// Check if it is "auto" color
  /// </summary>
  public bool IsAuto()
  {
    return Name== "auto";
  }

  /// <summary>
  /// Conversion from/to RGB
  /// </summary>
  public RGB? RGB
  {
    get => Value;
    set => Value = value; 
  }

  /// <summary>
  /// Gets "auto" or hexadecimal RGB value.
  /// </summary>
  /// <returns></returns>
  public override string? ToString()
  {
    if (IsAuto())
      return "auto";
    return Value?.ToString();
  }

  /// <summary>
  /// Conditional instance creation based on string.
  /// </summary>
  /// <param name="str"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public static bool TryParse(string str, out Color? value)
  {
    value = null;
    if (str=="auto")
      value = new Color("auto");
    else
    if (UInt32.TryParse(str, NumberStyles.HexNumber, null, out var val))
      value = new Color(new RGB(val));
    return value != null;
  }

}

using Qhta.Xml.Reflection;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the height of the current table row within the current table. 
///   This height shall be used to determine the resulting height of the table row, 
///   which can be absolute or relative (depending on its attribute values). 
/// </summary>
[TypeConverter(typeof(TableRowHeightTypeConverter))]
public class TableRowHeight: ModelElement
{
  /// <summary>
  ///   Table Row Height
  /// </summary>
  public ITwips Value { get; set; }
  /// <summary>
  ///   Table Row Height Type
  /// </summary>
  public HeightRuleKind? Type { get; set; }
  /// <summary>
  /// Default constructor.
  /// </summary>
  public TableRowHeight(){ }
  /// <summary>
  /// Initializing constructor with two parameters
  /// </summary>
  /// <param name="width">string representation of the value</param>
  /// <param name="type">Unit/Type specification</param>
  public TableRowHeight(Int64? width, HeightRuleKind? type)
  {
    Type = type;
    Value = width ?? 0;
  }
  /// <summary>
  /// Initializing constructor with one string parameter
  /// </summary>
  /// <param name="str">string representation of the value and type</param>
  public TableRowHeight(string? str)
  {
    if (str!=null)
    {
      var ss = str.Split(';');
      Value = ss[0];
      if (ss.Length > 1)
      {
        var s = ss[1].FirstLetterToUpper();
        if (Enum.TryParse<HeightRuleKind>(s, out var type))
          Type = type;
      }
    }
  }
  /// <summary>
  /// If the Type is "auto" then a string is emitted.
  /// Otherwise the Value is converted to string and the Type is added after semicolon.
  /// </summary>
  public override string? ToString()
  {
    if (Type == HeightRuleKind.Auto)
      return "auto";
    return Value.ToString()+";"+Type.ToString()?.FirstLetterToLower();
  }
  /// <summary>
  /// If the Type is "auto" then a string is emitted.
  /// Otherwise the Value is converted to string (using unit) and the Type is added after semicolon.
  /// </summary>
  public string? ToString(string? unit)
  {
    if (Type == HeightRuleKind.Auto)
      return "auto";
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }
  /// <summary>
  /// If the Type is "auto" then a string is emitted.
  /// Otherwise the Value is converted to string (using precision and unit) and the Type is added after semicolon.
  /// </summary>
  public string ToString(int precision, string? unit)
  {
    if (Type == HeightRuleKind.Auto)
      return "auto";
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }
  /// <summary>
  /// If the Type is "auto" then a string is emitted.
  /// Otherwise the Value is converted to string (using precision, provider and unit) and the Type is added after semicolon.
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    if (Type == HeightRuleKind.Auto)
      return "auto";
    string format = $"F{precision}";
    if (unit != null)
    {
      if (Value == 0)
        return "0";
      return Value.ToString(precision, provider, unit)+";"+ Type.ToString()?.FirstLetterToLower();
    }
    return Value.ToString();
  }
  /// <summary>
  /// If the Type is "auto" then a string is emitted.
  /// Otherwise the Value is converted to string (using provider and unit) and the Type is added after semicolon.
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (Type == HeightRuleKind.Auto)
      return "auto";
    if (unit != null)
    {
      if (Value==0)
        return "0";
      return Value.ToString(provider, unit)+";"+ Type.ToString()?.FirstLetterToLower();
    }
    return Value.ToString();
  }

}
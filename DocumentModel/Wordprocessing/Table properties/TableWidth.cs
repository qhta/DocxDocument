namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidth class. Its Value can be absolute (in twips) or relative (in fiftieth of percent), or "auto" or "nil".
///   The type of the Value is determined with the Type property.
///   This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[TypeConverter(typeof(TableWidthTypeConverter))]
public class TableWidth : ModelElement
{
  /// <summary>
  ///   Table Width value. Can be absolute (in twips) or relative (in fiftieth of percent).
  /// </summary>
  public Int64 Value { get; set; }

  /// <summary>
  ///   Table Width 
  /// </summary>
  public TableWidthUnitType? Type { get; set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public TableWidth(){ }

  /// <summary>
  /// Initializing constructor with two parameters
  /// </summary>
  /// <param name="width">string representation of the value</param>
  /// <param name="type">Unit/Type specification</param>
  public TableWidth(Int64? width, TableWidthUnitType? type)
  {
    Type = type;
    Value = width ?? 0;
  }

  /// <summary>
  /// Initializing constructor with two parameters
  /// </summary>
  /// <param name="width">string representation of the value</param>
  /// <param name="type">Unit/Type specification</param>
  public TableWidth(Int64? width, TableWidthKind? type)
  {
    if (type == TableWidthKind.Nil)
      Type = TableWidthUnitType.Nil;
    else
    if (type == TableWidthKind.Twips)
      Type = TableWidthUnitType.Twips;
    Value = width ?? 0;
  }

  /// <summary>
  /// Initializing converter with one string parameter
  /// </summary>
  /// <param name="str">string representation of the value and Unit/Type</param>
  public TableWidth(string? str)
  {
    if (str == null || str == "nil")
      Type = TableWidthUnitType.Nil;
    else
    if (str == "auto")
      Type = TableWidthUnitType.Auto;
    else if (str.EndsWith("%"))
    {
      Type = TableWidthUnitType.Pct;
      str = str.Substring(0, str.Length - 1);
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Value = (Int64)(val * 50);
    }
    else
    {
      Type = TableWidthUnitType.Twips;
      if (str.EndsWith("mm"))
      {
        str = str.Substring(0, str.Length - 2).Trim();
        var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * Twips.TwipsInMM;
        Value = (Int64)val;
      }
      if (str.EndsWith("cm"))
      {
        str = str.Substring(0, str.Length - 2).Trim();
        var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * Twips.TwipsInCM;
        Value = (Int64)val;
      }
      else if (str.EndsWith("in"))
      {
        str = str.Substring(0, str.Length - 2).Trim();
        var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * Twips.TwipsInInch;
        Value = (int)val;
      }
      else if (str.EndsWith("pt"))
      {
        str = str.Substring(0, str.Length - 2).Trim();
        var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * Twips.TwipsInPoint;
        Value = (Int64)val;
      }
      else Value = Int32.Parse(str);
    }
  }

  /// <summary>
  /// If the Type is "nil" or "auto" then a string is emitted.
  /// Otherwise the Percent or Value is converted to string.
  /// </summary>
  public override string? ToString()
  {
    if (Type == TableWidthUnitType.Nil)
      return "nil";
    if (Type == TableWidthUnitType.Auto)
      return "auto";
    if (Type == TableWidthUnitType.Pct)
      return (Value/50.0).ToString()+"%";
    return Value.ToString();
  }

  /// <summary>
  /// If the Type is "nil" or "auto" then a string is emitted.
  /// Otherwise the Percent or Value is converted to string (using unit).
  /// </summary>
  public string? ToString(string? unit)
  {
    if (Type == TableWidthUnitType.Nil)
      return "nil";
    if (Type == TableWidthUnitType.Auto)
      return "auto";
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// If the Type is "nil" or "auto" then a string is emitted.
  /// Otherwise the Percent or Value is converted to string (using precision and unit).
  /// </summary>
  public string ToString(int precision, string? unit)
  {
    if (Type == TableWidthUnitType.Nil)
      return "nil";
    if (Type == TableWidthUnitType.Auto)
      return "auto";
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// If the Type is "nil" or "auto" then a string is emitted.
  /// Otherwise the Percent or Value is converted to string (using precision, provider and unit).
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    if (Type == TableWidthUnitType.Nil)
      return "nil";
    if (Type == TableWidthUnitType.Auto)
      return "auto";
    string format = $"F{precision}";
    if (unit != null)
    {
      if (Value == 0)
        return "0";
      if (Type == TableWidthUnitType.Pct)
        return (Value / 50.0).ToString(format, provider)+"%";
      if (unit.EndsWith("mm"))
        return (Value / Twips.TwipsInMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / Twips.TwipsInCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / Twips.TwipsInInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / Twips.TwipsInPoint).ToString(format, provider) + unit;
    }
    return Value.ToString();
  }

  /// <summary>
  /// If the Type is "nil" or "auto" then a string is emitted.
  /// Otherwise the Percent or Value is converted to string (using provider and unit).
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (Type == TableWidthUnitType.Nil)
      return "nil";
    if (Type == TableWidthUnitType.Auto)
      return "auto";
    if (unit != null)
    {
      if (Value==0)
        return "0";
      if (Type == TableWidthUnitType.Pct)
        return (Value / 50.0).ToString(provider)+"%";
      if (unit.EndsWith("mm"))
        return (Value / Twips.TwipsInMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / Twips.TwipsInCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / Twips.TwipsInInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / Twips.TwipsInPoint).ToString(provider) + unit;
    }
    return Value.ToString();
  }

}
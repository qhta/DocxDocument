namespace DocumentModel;
/// <summary>
/// Twips unit. 1 twips = 1/1440 inch.
/// </summary>
public interface ITwips : IComparable<ITwips>
{
  /// <summary>
  /// Gets the value in twips from a string representation.
  /// Unit can be determined as string suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public void FromString(string str);
  /// <summary>
  /// Gets the value from UInt32 value.
  /// </summary>
  public void FromUInt(UInt32 value);

  /// <summary>
  /// Gets the value from Int32 value.
  /// </summary>
  public void FromInt(Int32 value);
  /// <summary>
  /// Gets the value from UInt64 value.
  /// </summary>
  public void FromUInt64(UInt64 value);
  /// <summary>
  /// Gets the value from Int64 value.
  /// </summary>
  public void FromInt(Int64 value);

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM();
  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM();

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch();
    
  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints();

  /// <summary>
  /// Converts integer value to string.
  /// </summary>
  public string ToString();
  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(string? unit);

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(int precision, string? unit);

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit);

  /// <summary>
  /// Converts double value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit);
}
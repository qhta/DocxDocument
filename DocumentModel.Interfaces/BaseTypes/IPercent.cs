namespace DocumentModel;
/// <summary>
/// Percent unit value.
/// </summary>
public interface IPercent: IComparable<IPercent>
{
  /// <summary>
  /// Get the value from hexadecimal string.
  /// </summary>
  public void FromHexString(string str);

  /// <summary>
  /// Converts value scale to hexadecimal string (two hex digits).
  /// </summary>
  public string ToHexString();

  /// <summary>
  /// Converts value to string with "%" suffix
  /// </summary>
  public string ToString();

  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined only as "%" suffix or null.
  /// </summary>
  public string ToString(string? unit);

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined only as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, string? unit);

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined only as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit);
}
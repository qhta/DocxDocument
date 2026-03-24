namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the weight of the border around a range.
/// </summary>
public enum XlBorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  Hairline = unchecked((int)1),
  /// <summary>
  /// Thin.
  /// </summary>
  Thin = unchecked((int)2),
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  Thick = unchecked((int)4),
  /// <summary>
  /// Specifies the weight of the border around a range.
  /// </summary>
  Medium = unchecked((int)-4138)
}

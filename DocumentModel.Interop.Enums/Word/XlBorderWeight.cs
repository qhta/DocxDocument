namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the weight of the border around a range.
/// </summary>
public enum XlBorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  xlHairline = unchecked((int)1),
  /// <summary>
  /// Thin.
  /// </summary>
  xlThin = unchecked((int)2),
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  xlThick = unchecked((int)4),
  /// <summary>
  /// Specifies the weight of the border around a range.
  /// </summary>
  xlMedium = unchecked((int)-4138)
}

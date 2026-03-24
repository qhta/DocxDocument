namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the weight of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlborderweight?view=office-pia` for Office interop details.
/// </remarks>
public enum XlBorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  Hairline = 1,
  /// <summary>
  /// Thin.
  /// </summary>
  Thin = 2,
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  Thick = 4,
  /// <summary>
  /// Medium.
  /// </summary>
  Medium = -4138
}

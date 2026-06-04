namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the weight of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlborderweight?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlBorderWeight")]
public enum BorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  [InteropEnumValue("xlHairline")]
  Hairline = 1,
  /// <summary>
  /// Thin.
  /// </summary>
  [InteropEnumValue("xlThin")]
  Thin = 2,
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  [InteropEnumValue("xlThick")]
  Thick = 4,
  /// <summary>
  /// Medium.
  /// </summary>
  [InteropEnumValue("xlMedium")]
  Medium = -4138
}

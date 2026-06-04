namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the weight of the border around a range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlborderweight?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlBorderWeight))]
public enum BorderWeight
{
  /// <summary>
  /// Hairline (thinnest border).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBorderWeight.xlHairline))]
  Hairline = 1,
  /// <summary>
  /// Thin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBorderWeight.xlThin))]
  Thin = 2,
  /// <summary>
  /// Thick (widest border).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBorderWeight.xlThick))]
  Thick = 4,
  /// <summary>
  /// Medium.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlBorderWeight.xlMedium))]
  Medium = -4138
}

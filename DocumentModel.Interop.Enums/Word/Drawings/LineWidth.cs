namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the width of an object's border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinewidth?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLineWidth")]
public enum LineWidth
{
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth025pt")]
  Pt025 = 2,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth050pt")]
  Pt050 = 4,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth075pt")]
  Pt075 = 6,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth100pt")]
  Pt100 = 8,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth150pt")]
  Pt150 = 12,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth225pt")]
  Pt225 = 18,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth300pt")]
  Pt300 = 24,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth450pt")]
  Pt450 = 36,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [InteropEnumValue("wdLineWidth600pt")]
  Pt600 = 48
}

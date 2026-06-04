namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the width of an object's border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinewidth?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLineWidth))]
public enum LineWidth
{
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth025pt))]
  Pt025 = 2,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth050pt))]
  Pt050 = 4,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth075pt))]
  Pt075 = 6,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth100pt))]
  Pt100 = 8,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth150pt))]
  Pt150 = 12,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth225pt))]
  Pt225 = 18,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth300pt))]
  Pt300 = 24,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth450pt))]
  Pt450 = 36,
  /// <summary>
  /// Specifies the width of an object's border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineWidth.wdLineWidth600pt))]
  Pt600 = 48
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlVAlign))]
public enum VAlign
{
  /// <summary>
  /// Top
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlVAlign.xlVAlignTop))]
  Top = -4160,
  /// <summary>
  /// Justify
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlVAlign.xlVAlignJustify))]
  Justify = -4130,
  /// <summary>
  /// Distributed
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlVAlign.xlVAlignDistributed))]
  Distributed = -4117,
  /// <summary>
  /// Center
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlVAlign.xlVAlignCenter))]
  Center = -4108,
  /// <summary>
  /// Bottom
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlVAlign.xlVAlignBottom))]
  Bottom = -4107
}

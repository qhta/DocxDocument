namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdverticalalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdVerticalAlignment")]
public enum VerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  [InteropEnumValue("wdAlignVerticalTop")]
  Top = 0,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  [InteropEnumValue("wdAlignVerticalCenter")]
  Center = 1,
  /// <summary>
  /// Justified vertical alignment.
  /// </summary>
  [InteropEnumValue("wdAlignVerticalJustify")]
  Justify = 2,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  [InteropEnumValue("wdAlignVerticalBottom")]
  Bottom = 3
}

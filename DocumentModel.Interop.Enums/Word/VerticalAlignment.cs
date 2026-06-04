namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdverticalalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdVerticalAlignment")]
public enum VerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  [WordInteropEnumValue("wdAlignVerticalTop")]
  Top = 0,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  [WordInteropEnumValue("wdAlignVerticalCenter")]
  Center = 1,
  /// <summary>
  /// Justified vertical alignment.
  /// </summary>
  [WordInteropEnumValue("wdAlignVerticalJustify")]
  Justify = 2,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  [WordInteropEnumValue("wdAlignVerticalBottom")]
  Bottom = 3
}

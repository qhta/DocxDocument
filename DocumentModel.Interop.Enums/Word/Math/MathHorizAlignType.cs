namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the horizontal alignment for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathhorizaligntype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathHorizAlignType")]
public enum MathHorizAlignType
{
  /// <summary>
  /// Centered.
  /// </summary>
  [InteropEnumValue("wdOMathHorizAlignCenter")]
  Center = 0,
  /// <summary>
  /// Left alignment.
  /// </summary>
  [InteropEnumValue("wdOMathHorizAlignLeft")]
  Left = 1,
  /// <summary>
  /// Right alignment.
  /// </summary>
  [InteropEnumValue("wdOMathHorizAlignRight")]
  Right = 2
}

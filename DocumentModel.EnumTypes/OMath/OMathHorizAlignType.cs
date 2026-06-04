namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the horizontal alignment for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathhorizaligntype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathHorizAlignType))]
public enum OMathHorizAlignType
{
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathHorizAlignType.wdOMathHorizAlignCenter))]
  Center = 0,
  /// <summary>
  /// Left alignment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathHorizAlignType.wdOMathHorizAlignLeft))]
  Left = 1,
  /// <summary>
  /// Right alignment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathHorizAlignType.wdOMathHorizAlignRight))]
  Right = 2
}

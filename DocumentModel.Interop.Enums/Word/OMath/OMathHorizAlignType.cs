namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the horizontal alignment for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathhorizaligntype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathHorizAlignType")]
public enum OMathHorizAlignType
{
  /// <summary>
  /// Centered.
  /// </summary>
  [WordInteropEnumValue("wdOMathHorizAlignCenter")]
  Center = 0,
  /// <summary>
  /// Left alignment.
  /// </summary>
  [WordInteropEnumValue("wdOMathHorizAlignLeft")]
  Left = 1,
  /// <summary>
  /// Right alignment.
  /// </summary>
  [WordInteropEnumValue("wdOMathHorizAlignRight")]
  Right = 2
}

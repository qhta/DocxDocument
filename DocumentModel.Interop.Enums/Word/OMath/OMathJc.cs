namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathjc?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathJc")]
public enum OMathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  [WordInteropEnumValue("wdOMathJcCenterGroup")]
  CenterGroup = 1,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue("wdOMathJcCenter")]
  Center = 2,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue("wdOMathJcLeft")]
  Left = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue("wdOMathJcRight")]    
  Right = 4,
  /// <summary>
  /// Inline.
  /// </summary>
  [WordInteropEnumValue("wdOMathJcInline")]
  Inline = 7
}

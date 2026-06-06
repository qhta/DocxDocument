namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathjc?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathJc")]
public enum MathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  [InteropEnumValue("wdOMathJcCenterGroup")]
  CenterGroup = 1,
  /// <summary>
  /// Center.
  /// </summary>
  [InteropEnumValue("wdOMathJcCenter")]
  Center = 2,
  /// <summary>
  /// Left.
  /// </summary>
  [InteropEnumValue("wdOMathJcLeft")]
  Left = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [InteropEnumValue("wdOMathJcRight")]    
  Right = 4,
  /// <summary>
  /// Inline.
  /// </summary>
  [InteropEnumValue("wdOMathJcInline")]
  Inline = 7
}

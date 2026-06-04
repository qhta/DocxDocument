namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathjc?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathJc))]
public enum OMathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathJc.wdOMathJcCenterGroup))]
  CenterGroup = 1,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathJc.wdOMathJcCenter))]
  Center = 2,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathJc.wdOMathJcLeft))]
  Left = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathJc.wdOMathJcRight))]    
  Right = 4,
  /// <summary>
  /// Inline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathJc.wdOMathJcInline))]
  Inline = 7
}

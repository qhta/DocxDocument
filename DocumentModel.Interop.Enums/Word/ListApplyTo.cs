namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the portion of a list to which to apply a list template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistapplyto?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdListApplyTo")]
public enum ListApplyTo
{
  /// <summary>
  /// Entire list.
  /// </summary>
  [InteropEnumValue("wdListApplyToWholeList")]
  WholeList = 0,
  /// <summary>
  /// From cursor insertion point to end of list.
  /// </summary>
  [InteropEnumValue("wdListApplyToThisPointForward")]
  ThisPointForward = 1,
  /// <summary>
  /// Selection.
  /// </summary>
  [InteropEnumValue("wdListApplyToSelection")]
  Selection = 2
}

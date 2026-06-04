namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target document for displaying document comparison differences.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcomparetarget?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCompareTarget")]
public enum CompareTarget
{
  /// <summary>
  /// Places comparison differences in the target document.
  /// </summary>
  [InteropEnumValue("wdCompareTargetSelected")]
  Selected = 0,
  /// <summary>
  /// Places comparison differences in the current document. Default.
  /// </summary>
  [InteropEnumValue("wdCompareTargetCurrent")]
  Current = 1,
  /// <summary>
  /// Places comparison differences in a new document.
  /// </summary>
  [InteropEnumValue("wdCompareTargetNew")]
  New = 2
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the target document for displaying document comparison differences.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcomparetarget?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCompareTarget
{
  /// <summary>
  /// Places comparison differences in the target document.
  /// </summary>
  Selected = 0,
  /// <summary>
  /// Places comparison differences in the current document. Default.
  /// </summary>
  Current = 1,
  /// <summary>
  /// Places comparison differences in a new document.
  /// </summary>
  New = 2
}

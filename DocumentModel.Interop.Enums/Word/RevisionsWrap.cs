namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revision marks are displayed in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionswrap?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRevisionsWrap")]
public enum RevisionsWrap
{
  /// <summary>
  /// Never wrap revisions.
  /// </summary>
  [InteropEnumValue("wdWrapNever")]
  Never = 0,
  /// <summary>
  /// Revisions are wrapped.
  /// </summary>
  [InteropEnumValue("wdWrapAlways")]
  Always = 1,
  /// <summary>
  /// Ask the user if revisions should be wrapped.
  /// </summary>
  [InteropEnumValue("wdWrapAsk")]
  Ask = 2
}

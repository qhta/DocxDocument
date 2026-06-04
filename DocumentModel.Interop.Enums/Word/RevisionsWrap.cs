namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revision marks are displayed in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionswrap?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisionsWrap))]
public enum RevisionsWrap
{
  /// <summary>
  /// Never wrap revisions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsWrap.wdWrapNever))]
  Never = 0,
  /// <summary>
  /// Revisions are wrapped.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsWrap.wdWrapAlways))]
  Always = 1,
  /// <summary>
  /// Ask the user if revisions should be wrapped.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsWrap.wdWrapAsk))]
  Ask = 2
}

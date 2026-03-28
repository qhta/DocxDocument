namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revision marks are displayed in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionswrap?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRevisionsWrap
{
  /// <summary>
  /// Never wrap revisions.
  /// </summary>
  Never = 0,
  /// <summary>
  /// Revisions are wrapped.
  /// </summary>
  Always = 1,
  /// <summary>
  /// Ask the user if revisions should be wrapped.
  /// </summary>
  Ask = 2
}

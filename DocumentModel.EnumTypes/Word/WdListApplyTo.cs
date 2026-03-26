namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the portion of a list to which to apply a list template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistapplyto?view=office-pia` for Office interop details.
/// </remarks>
public enum ListApplyTo
{
  /// <summary>
  /// Entire list.
  /// </summary>
  WholeList = 0,
  /// <summary>
  /// From cursor insertion point to end of list.
  /// </summary>
  ThisPointForward = 1,
  /// <summary>
  /// Selection.
  /// </summary>
  Selection = 2
}

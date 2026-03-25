namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial interface ListFormat: InteropObject
{
  /// <summary>
  /// Returns whether the specified list template can continue the formatting of the previous list.
  /// </summary>
  /// <param name="ListTemplate">The list template to check.</param>
  /// <returns>A value that indicates whether numbering can continue from the previous list.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.cancontinuepreviouslist?view=word-pia"/>
  public WdContinue CanContinuePreviousList(ListTemplate ListTemplate);
}

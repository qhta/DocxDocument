namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat?view=word-pia"/>
public partial interface ListFormat
{
  /// <summary>
  /// Determines whether the specified list template can continue the previous list.
  /// </summary>
  /// <param name="ListTemplate">The list template to check.</param>
  /// <returns>A <see cref="WdContinue"/> value indicating if the list can continue.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listformat.cancontinuepreviouslist?view=word-pia"/>
  public WdContinue CanContinuePreviousList(ListTemplate ListTemplate);
}

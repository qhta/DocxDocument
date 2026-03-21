namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries?view=word-pia"/>
public partial interface OMathAutoCorrectEntries
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Value">Specifies the value.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries.add?view=word-pia"/>
  public OMathAutoCorrectEntry Add(string Name, string Value);
}

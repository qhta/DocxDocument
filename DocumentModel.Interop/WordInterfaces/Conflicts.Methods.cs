namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts?view=word-pia"/>
public partial interface Conflicts
{
  /// <summary>
  /// Accepts all conflicts in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts.acceptall?view=word-pia"/>
  public void AcceptAll();

  /// <summary>
  /// Rejects all conflicts in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts.rejectall?view=word-pia"/>
  public void RejectAll();
}

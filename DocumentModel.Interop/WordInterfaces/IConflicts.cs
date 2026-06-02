namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Conflict objects that represents the conflicts in a document. The type of a Conflict object is specified by the RevisionType enumeration.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts?view=word-pia"/>
public interface IConflicts : IInteropObject, IInteropCollection<Conflict>
{


  #region methods

/// <summary>
  /// Accepts all conflict changes, removes the conflicts, and merges the changes into the server copy of the
  /// document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts.acceptall?view=word-pia"/>
  public void AcceptAll();

  /// <summary>
  /// Rejects all of the user's changes and retains the server copy of the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts.rejectall?view=word-pia"/>
  public void RejectAll();

  #endregion methods
}

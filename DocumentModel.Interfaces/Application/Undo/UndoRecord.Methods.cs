namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord?view=word-pia"/>
public partial interface IUndoRecord: IModelObject
{
  /// <summary>
  /// Starts a custom undo record with the specified name.
  /// </summary>
  /// <param name="Name">The name of the custom undo record.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.startcustomrecord?view=word-pia"/>
  public void StartCustomRecord(string Name);
}

namespace DocumentModel.Interop.Word;

public partial interface UndoRecord
{
  /// <summary>
  /// Starts a custom undo record with the specified name.
  /// </summary>
  /// <param name="Name">The name of the custom undo record.</param>
  public void StartCustomRecord(string Name);
}

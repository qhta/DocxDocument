namespace DocumentModel.Wordprocessing;

/// <summary>
/// Provides an entry point into the undo stack.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord?view=word-pia"/>
public partial interface UndoRecord : IModelObject
{
  /// <summary>
  /// Gets whether a custom undo action is being recorded.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.isrecordingcustomrecord?view=word-pia"/>
  public bool IsRecordingCustomRecord { get; }

  /// <summary>
  /// Gets a string that specifies the entry that appears on the undo stack when all custom undo actions have
  /// completed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordname?view=word-pia"/>
  public string CustomRecordName { get; }

  /// <summary>
  /// Gets a value that specifies the number of custom undo action calls that are currently active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordlevel?view=word-pia"/>
  public int CustomRecordLevel { get; }
}

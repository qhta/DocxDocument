namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides an entry point into the undo stack.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord?view=word-pia"/>
public partial interface UndoRecord : InteropObject
{
  /// <summary>
  /// Returns whether recording custom record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.isrecordingcustomrecord?view=word-pia"/>
  public bool IsRecordingCustomRecord { get; }

  /// <summary>
  /// Returns the custom record name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordname?view=word-pia"/>
  public string CustomRecordName { get; }

  /// <summary>
  /// Returns the custom record level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordlevel?view=word-pia"/>
  public int CustomRecordLevel { get; }
}

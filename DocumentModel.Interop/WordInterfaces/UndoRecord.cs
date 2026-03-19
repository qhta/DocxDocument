namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides an entry point into the undo stack.
/// </summary>
public partial interface UndoRecord : InteropObject
{
  /// <summary>
  /// The is recording custom record.
  /// </summary>
  public bool IsRecordingCustomRecord { get; }

  /// <summary>
  /// The custom record name.
  /// </summary>
  public string CustomRecordName { get; }

  /// <summary>
  /// The custom record level.
  /// </summary>
  public int CustomRecordLevel { get; }
}

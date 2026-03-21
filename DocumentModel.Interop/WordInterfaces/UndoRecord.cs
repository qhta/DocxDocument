namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides an entry point into the undo stack.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord?view=word-pia"/>
public partial interface UndoRecord : InteropObject
{
  /// <summary>
  /// The is recording custom record.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.isrecordingcustomrecord?view=word-pia"/>
  public bool IsRecordingCustomRecord { get; }

  /// <summary>
  /// The custom record name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordname?view=word-pia"/>
  public string CustomRecordName { get; }

  /// <summary>
  /// The custom record level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.undorecord.customrecordlevel?view=word-pia"/>
  public int CustomRecordLevel { get; }
}

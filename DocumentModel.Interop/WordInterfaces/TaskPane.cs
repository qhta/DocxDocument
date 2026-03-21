namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single task pane available to Microsoft Word, which contains common tasks that users perform.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpane?view=word-pia"/>
public interface TaskPane : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpane.visible?view=word-pia"/>
  public bool Visible { get; set; }

}

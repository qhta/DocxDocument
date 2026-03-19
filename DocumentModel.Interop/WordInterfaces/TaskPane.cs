namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single task pane available to Microsoft Word, which contains common tasks that users perform.
/// </summary>
public interface TaskPane : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }

}

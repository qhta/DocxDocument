namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesSize Class.
/// </summary>
public class NotesSize: INotesSize
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy
  {
    get;
    set;
  }
  
}

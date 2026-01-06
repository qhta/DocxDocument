namespace DocumentModel.Wordprocessing;
/// <summary>
///   Common base interface for 
///   <see cref="InsertedRun"/>, <see cref="DeletedRun"/>, <see cref="MoveFromRun"/>, <see cref="MoveToRun"/> classes.
/// </summary>
public interface RunTrackChangeType: IElementCollection<ParagraphContent>, CommonContent
{
  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}
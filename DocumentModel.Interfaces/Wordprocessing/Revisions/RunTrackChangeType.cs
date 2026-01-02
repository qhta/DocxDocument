namespace DocumentModel.Wordprocessing;
/// <summary>
///   Common base class for 
///   <see cref="InsertedRun"/>, <see cref="DeletedRun"/>, <see cref="MoveFromRun"/>, <see cref="MoveToRun"/> classes.
/// </summary>
public abstract class RunTrackChangeType: ElementCollection<IParagraphContent>, ICommonContent
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
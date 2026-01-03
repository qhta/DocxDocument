namespace DocumentModel;

/// <summary>
///   Defines the TaskProgressEventInfo Class.
/// </summary>
public interface TaskProgressEventInfo: IModelElement
{
  /// <summary>
  ///   percentComplete
  /// </summary>
  public Int32? PercentComplete { get; set; }
}
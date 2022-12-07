namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public interface ObjectLink
{
  /// <summary>
  /// updateMode
  /// </summary>
  public ObjectUpdateMode? UpdateMode { get ; set; }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public ObjectDrawAspect? drawAspect { get ; set; }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public interface ObjectLink
{
  /// <summary>
  /// updateMode
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectUpdateMode? UpdateMode { get ; set; }
  
  /// <summary>
  /// lockedField
  /// </summary>
  public Boolean? LockedField { get ; set; }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectDrawAspect? drawAspect { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// progId
  /// </summary>
  public String? ProgId { get ; set; }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public String? FieldCodes { get ; set; }
  
}

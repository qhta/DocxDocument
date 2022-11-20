namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public class ObjectLink: IObjectLink
{
  /// <summary>
  /// updateMode
  /// </summary>
  public ObjectUpdateMode? UpdateMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  public bool? LockedField
  {
    get;
    set;
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public ObjectDrawAspect? drawAspect
  {
    get;
    set;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public string? ProgId
  {
    get;
    set;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public string? FieldCodes
  {
    get;
    set;
  }
  
}

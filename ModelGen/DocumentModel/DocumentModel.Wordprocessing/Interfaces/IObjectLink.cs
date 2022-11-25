namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public interface IObjectLink // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// updateMode
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectUpdateMode? UpdateMode { get ; set; }
  
  /// <summary>
  /// lockedField
  /// </summary>
  public System.Boolean? LockedField { get ; set; }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectDrawAspect? drawAspect { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// progId
  /// </summary>
  public System.String? ProgId { get ; set; }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public System.String? FieldCodes { get ; set; }
  
}

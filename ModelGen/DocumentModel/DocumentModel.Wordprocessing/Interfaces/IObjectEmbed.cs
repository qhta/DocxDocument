namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public interface IObjectEmbed // : DocumentModel.ITypedOpenXmlLeafElement
{
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

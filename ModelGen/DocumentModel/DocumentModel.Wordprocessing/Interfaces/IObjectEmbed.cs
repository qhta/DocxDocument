namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public interface IObjectEmbed // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// drawAspect
  /// </summary>
  public ObjectDrawAspect? drawAspect { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// progId
  /// </summary>
  public string? ProgId { get ; set; }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public string? ShapeId { get ; set; }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public string? FieldCodes { get ; set; }
  
}

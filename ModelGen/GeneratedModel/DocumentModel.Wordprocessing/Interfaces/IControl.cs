namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public interface IControl // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  public string? ShapeId { get ; set; }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  public string? Id { get ; set; }
  
}

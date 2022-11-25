namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public interface IControl // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  public System.String? Id { get ; set; }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public interface Point
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public DocumentModel.Drawings.PointKind? Type { get ; set; }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId { get ; set; }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public DocumentModel.Drawings.PropertySet? PropertySet { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawings.TextBody? TextBody { get ; set; }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.PtExtensionList? PtExtensionList { get ; set; }
  
}

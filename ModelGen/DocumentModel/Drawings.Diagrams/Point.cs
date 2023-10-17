namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Point.
/// </summary>
public partial class Point
{
  
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public String? ModelId { get; set; }
  
  
  /// <summary>
  ///   Point Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PointKind? Type { get; set; }
  
  
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  public String? ConnectionId { get; set; }
  
  
  /// <summary>
  ///   Property Set.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PropertySet? PropertySet { get; set; }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Text Body.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextBody? TextBody { get; set; }
  
  
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PtExtensionList? PtExtensionList { get; set; }
  
}

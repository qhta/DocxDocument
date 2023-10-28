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
  ///   Connection Identifier
  /// </summary>
  public String? ConnectionId { get; set; }
  
  
  /// <summary>
  ///   Property Set.
  /// </summary>
  public DMDD.PropertySet? PropertySet { get; set; }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public DMDD.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Text Body.
  /// </summary>
  public DMDD.TextBody? TextBody { get; set; }
  
  
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  public DMDD.PtExtensionList? PtExtensionList { get; set; }
  
}

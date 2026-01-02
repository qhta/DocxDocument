namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Point.
/// </summary>
public class Point: ModelElement
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public string? ModelId { get; set; }
  /// <summary>
  ///   Point Type
  /// </summary>
  public PointKind? Type { get; set; }
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  public string? ConnectionId { get; set; }
  /// <summary>
  ///   Property Set.
  /// </summary>
  public PropertySet? PropertySet { get; set; }
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   Text Body.
  /// </summary>
  public TextBody? TextBody { get; set; }
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  public PtExtensionList? PtExtensionList { get; set; }
}
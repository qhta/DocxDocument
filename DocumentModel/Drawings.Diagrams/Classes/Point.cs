namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IPoint.
/// </summary>
public class IPoint: ModelElement
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public string? ModelId { get; set; }

  /// <summary>
  ///   IPoint Type
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
  ///   IShape Properties.
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

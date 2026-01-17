namespace DocumentModel.Drawings;

/// <summary>
///   Represents custom geometry for a shape, including adjustment values, guides, handles, connection sites, text rectangle, and paths.
/// </summary>
public class CustomGeometry: ModelElement<DXD.CustomGeometry>
{
  /// <summary>
  ///   List of adjustment values for the custom geometry.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }

  /// <summary>
  ///   List of shape guides used to define geometry.
  /// </summary>
  public ShapeGuideList? ShapeGuideList { get; set; }

  /// <summary>
  ///   List of shape adjust handles for interactive adjustments.
  /// </summary>
  public AdjustHandleList? AdjustHandleList { get; set; }

  /// <summary>
  ///   List of connection sites for attaching connectors.
  /// </summary>
  public ConnectionSiteList? ConnectionSiteList { get; set; }

  /// <summary>
  ///   Rectangle that defines the text area within the shape.
  /// </summary>
  public Rectangle? Rectangle { get; set; }

  /// <summary>
  ///   List of paths that describe the outline of the custom geometry.
  /// </summary>
  public PathList? PathList { get; set; }
}
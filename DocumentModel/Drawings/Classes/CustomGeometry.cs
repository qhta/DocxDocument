namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom geometry.
/// </summary>
public class CustomGeometry: ModelElement
{
  /// <summary>
  ///   Adjust Value IList.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }

  /// <summary>
  ///   IList of IShape Guides.
  /// </summary>
  public ShapeGuideList? ShapeGuideList { get; set; }

  /// <summary>
  ///   IList of IShape Adjust Handles.
  /// </summary>
  public AdjustHandleList? AdjustHandleList { get; set; }

  /// <summary>
  ///   IList of IShape Connection Sites.
  /// </summary>
  public ConnectionSiteList? ConnectionSiteList { get; set; }

  /// <summary>
  ///   IShape Text IRectangle.
  /// </summary>
  public IRectangle? IRectangle { get; set; }

  /// <summary>
  ///   IList of IShape Paths.
  /// </summary>
  public PathList? PathList { get; set; }
}

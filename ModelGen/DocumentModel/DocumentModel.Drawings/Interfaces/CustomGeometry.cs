namespace DocumentModel.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public interface CustomGeometry
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public AdjustValueList? AdjustValueList { get ; set; }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public ShapeGuideList? ShapeGuideList { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public AdjustHandleList? AdjustHandleList { get ; set; }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public ConnectionSiteList? ConnectionSiteList { get ; set; }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public Rectangle? Rectangle { get ; set; }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public PathList? PathList { get ; set; }
  
}

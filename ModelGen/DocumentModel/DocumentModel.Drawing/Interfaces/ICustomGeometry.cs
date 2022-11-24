namespace DocumentModel.Drawing;

/// <summary>
/// Custom geometry.
/// </summary>
public interface ICustomGeometry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public IAdjustValueList? AdjustValueList { get ; set; }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public IShapeGuideList? ShapeGuideList { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public IAdjustHandleList? AdjustHandleList { get ; set; }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public IConnectionSiteList? ConnectionSiteList { get ; set; }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public IRectangle? Rectangle { get ; set; }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public IPathList? PathList { get ; set; }
  
}

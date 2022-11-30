namespace DocumentModel.Drawing;

/// <summary>
/// Custom geometry.
/// </summary>
public interface ICustomGeometry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawing.IAdjustValueList? AdjustValueList { get ; set; }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public DocumentModel.Drawing.IShapeGuideList? ShapeGuideList { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public DocumentModel.Drawing.IAdjustHandleList? AdjustHandleList { get ; set; }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public DocumentModel.Drawing.IConnectionSiteList? ConnectionSiteList { get ; set; }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRectangle? Rectangle { get ; set; }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public DocumentModel.Drawing.IPathList? PathList { get ; set; }
  
}

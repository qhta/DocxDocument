namespace DocumentModel.Drawing;

/// <summary>
/// Custom geometry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustHandleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IConnectionSiteList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustValueList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeGuideList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRectangle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPathList))]
public class CustomGeometry: ICustomGeometry
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public IAdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public IShapeGuideList? ShapeGuideList
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public IAdjustHandleList? AdjustHandleList
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public IConnectionSiteList? ConnectionSiteList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRectangle? Rectangle
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public IPathList? PathList
  {
    get;
    set;
  }
  
}

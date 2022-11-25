namespace DocumentModel.Drawing;

/// <summary>
/// Custom geometry.
/// </summary>
public interface ICustomGeometry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? AdjustValueList { get ; set; }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ShapeGuideList { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? AdjustHandleList { get ; set; }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ConnectionSiteList { get ; set; }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRectangle? Rectangle { get ; set; }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PathList { get ; set; }
  
}

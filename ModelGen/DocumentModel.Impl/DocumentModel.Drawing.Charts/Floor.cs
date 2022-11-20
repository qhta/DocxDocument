namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D floor formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IThickness))]
public class Floor: IFloor
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public IThickness? Thickness
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public IPictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}

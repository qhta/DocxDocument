namespace DocumentModel.Drawing;

/// <summary>
/// Shape Default.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
public class ShapeDefault: IShapeDefault
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public IBodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public IListStyle? ListStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}

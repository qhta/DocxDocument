namespace DocumentModel.Drawing.Pictures;

/// <summary>
/// Picture.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Pictures.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Pictures.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.INonVisualPictureProperties))]
public class Picture: IPicture
{
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.INonVisualPictureProperties? NonVisualPictureProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawing.Pictures.IBlipFill? BlipFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Drawing.Pictures.IShapeStyle? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Drawing.Pictures.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}

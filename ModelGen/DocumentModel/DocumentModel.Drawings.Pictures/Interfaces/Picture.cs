namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Picture.
/// </summary>
public partial interface Picture
{
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualPictureProperties? NonVisualPictureProperties { get; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawings.Pictures.BlipFill? BlipFill { get; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// ShapeStyle, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Drawings.Pictures.ShapeStyle? ShapeStyle { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Drawings.Pictures.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}

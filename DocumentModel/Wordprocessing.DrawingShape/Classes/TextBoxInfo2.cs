namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the TextBoxInfo2 Class.
/// </summary>
public partial class TextBoxInfo2
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id { get; set; }
  
  /// <summary>
  /// TextBoxContent.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}

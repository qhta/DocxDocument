namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the TextBoxInfo2 Class.
/// </summary>
public interface ITextBoxInfo2 // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id { get ; set; }
  
  /// <summary>
  /// TextBoxContent.
  /// </summary>
  public ITextBoxContent? TextBoxContent { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}

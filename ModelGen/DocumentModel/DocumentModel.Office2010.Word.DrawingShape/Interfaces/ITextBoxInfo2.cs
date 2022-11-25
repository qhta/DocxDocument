namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the TextBoxInfo2 Class.
/// </summary>
public interface ITextBoxInfo2 // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt16? Id { get ; set; }
  
  /// <summary>
  /// TextBoxContent.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TextBoxContent { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}

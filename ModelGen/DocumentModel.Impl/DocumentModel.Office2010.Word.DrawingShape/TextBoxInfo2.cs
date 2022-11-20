namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the TextBoxInfo2 Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextBoxContent))]
public class TextBoxInfo2: ITextBoxInfo2
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public ushort? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBoxContent.
  /// </summary>
  public ITextBoxContent? TextBoxContent
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingShape.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}

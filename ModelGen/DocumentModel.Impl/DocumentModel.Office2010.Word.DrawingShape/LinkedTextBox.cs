namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the LinkedTextBox Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IOfficeArtExtensionList))]
public class LinkedTextBox: ILinkedTextBox
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
  /// seq, this property is only available in Office 2010 and later.
  /// </summary>
  public ushort? Sequence
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

namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the LinkedTextBox Class.
/// </summary>
public partial interface LinkedTextBox
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id { get; set; }
  
  /// <summary>
  /// seq, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Sequence { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}

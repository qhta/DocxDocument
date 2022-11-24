namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the LinkedTextBox Class.
/// </summary>
public interface ILinkedTextBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Id { get ; set; }
  
  /// <summary>
  /// seq, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt16? Sequence { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}

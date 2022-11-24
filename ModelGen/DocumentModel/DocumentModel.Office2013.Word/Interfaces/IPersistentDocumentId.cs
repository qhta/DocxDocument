namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the PersistentDocumentId Class.
/// </summary>
public interface IPersistentDocumentId // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Val { get ; set; }
  
}

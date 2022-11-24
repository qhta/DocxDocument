namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the DocumentId Class.
/// </summary>
public interface IDocumentId // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}

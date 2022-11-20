namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the PersistentDocumentId Class.
/// </summary>
public interface IPersistentDocumentId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}

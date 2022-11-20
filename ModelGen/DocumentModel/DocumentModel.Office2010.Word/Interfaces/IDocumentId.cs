namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the DocumentId Class.
/// </summary>
public interface IDocumentId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}

namespace DocumentModel.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public class AlternativeFormatImportPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, AlternativeFormatImportPart
{
  public new DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AlternativeFormatImportPartImpl(): base() {}
  
  public AlternativeFormatImportPartImpl(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

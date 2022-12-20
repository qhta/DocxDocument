namespace DocumentModel.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public partial class AlternativeFormatImportPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, AlternativeFormatImportPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AlternativeFormatImportPartImpl(): base() {}
  
  public AlternativeFormatImportPartImpl(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}

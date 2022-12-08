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
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}

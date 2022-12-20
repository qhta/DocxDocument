namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public partial class WordprocessingPrinterSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordprocessingPrinterSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WordprocessingPrinterSettingsPartImpl(): base() {}
  
  public WordprocessingPrinterSettingsPartImpl(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}

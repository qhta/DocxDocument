namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public class WordprocessingPrinterSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordprocessingPrinterSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

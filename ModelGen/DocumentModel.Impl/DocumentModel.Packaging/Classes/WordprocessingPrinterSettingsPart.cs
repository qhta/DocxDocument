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
  
  public WordprocessingPrinterSettingsPartImpl(): base() {}
  
  public WordprocessingPrinterSettingsPartImpl(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

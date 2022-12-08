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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}

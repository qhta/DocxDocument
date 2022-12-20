namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public partial class SpreadsheetPrinterSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SpreadsheetPrinterSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SpreadsheetPrinterSettingsPartImpl(): base() {}
  
  public SpreadsheetPrinterSettingsPartImpl(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart openXmlElement): base(openXmlElement)
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

namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public class SpreadsheetPrinterSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SpreadsheetPrinterSettingsPart
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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

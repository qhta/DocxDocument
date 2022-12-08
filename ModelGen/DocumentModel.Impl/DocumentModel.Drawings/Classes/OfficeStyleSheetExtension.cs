namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public class OfficeStyleSheetExtensionImpl: ModelElementImpl, OfficeStyleSheetExtension
{
  public DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public DocumentModel.ThemeFamily? ThemeFamily
  {
    get;
    set;
  }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public class OfficeStyleSheetExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>, OfficeStyleSheetExtension
{
  public DocumentModel.ThemeFamily? ThemeFamily
  {
    get;
    set;
  }
  
}

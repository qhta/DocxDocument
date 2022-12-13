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
  
  public OfficeStyleSheetExtensionImpl(): base() {}
  
  public OfficeStyleSheetExtensionImpl(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.ThemeFamily? ThemeFamily
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

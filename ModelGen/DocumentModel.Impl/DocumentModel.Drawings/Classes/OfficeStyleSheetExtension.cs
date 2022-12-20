namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public partial class OfficeStyleSheetExtensionImpl: ModelElementImpl, OfficeStyleSheetExtension
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>();
        if (item != null)
          return new DocumentModel.ThemeFamilyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ThemeFamilyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

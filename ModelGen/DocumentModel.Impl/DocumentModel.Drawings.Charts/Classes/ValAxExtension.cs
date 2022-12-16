namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public class ValAxExtensionImpl: ModelElementImpl, ValAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValAxExtensionImpl(): base() {}
  
  public ValAxExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Charts.NumberingFormat3? NumberingFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumberingFormat3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumberingFormat3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

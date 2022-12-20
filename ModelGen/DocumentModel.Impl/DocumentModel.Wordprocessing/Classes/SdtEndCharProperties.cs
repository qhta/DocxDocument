namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public partial class SdtEndCharPropertiesImpl: ModelElementImpl, SdtEndCharProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtEndCharPropertiesImpl(): base() {}
  
  public SdtEndCharPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.RunProperties? RunProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

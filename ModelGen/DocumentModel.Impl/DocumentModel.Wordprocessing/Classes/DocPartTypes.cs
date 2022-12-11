namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public class DocPartTypesImpl: ModelElementImpl, DocPartTypes
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartTypes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocPartTypesImpl(): base() {}
  
  public DocPartTypesImpl(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public Boolean? All
  {
    get => (Boolean?)OpenXmlElement?.All?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.All = (System.Boolean?)value;
    }
  }
  
  public DocPartKind? DocPartType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
        return (DocPartKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DocPartType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}

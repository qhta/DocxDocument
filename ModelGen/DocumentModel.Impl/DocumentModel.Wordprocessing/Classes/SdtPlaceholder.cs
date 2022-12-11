namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public class SdtPlaceholderImpl: ModelElementImpl, SdtPlaceholder
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtPlaceholderImpl(): base() {}
  
  public SdtPlaceholderImpl(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public String? DocPartReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartReference>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartReference>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DocPartReference{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}

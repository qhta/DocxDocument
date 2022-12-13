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
    get => (System.String?)OpenXmlElement?.DocPartReference?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DocPartReference != null)
        {
          if (value is not null)
            OpenXmlElement.DocPartReference.Val = (System.String?)value;
          else
            OpenXmlElement.DocPartReference = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DocPartReference = new DocumentFormat.OpenXml.Wordprocessing.DocPartReference{ Val = (System.String?)value };
        }
      }
    }
  }
  
}

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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartReference>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartReference{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}

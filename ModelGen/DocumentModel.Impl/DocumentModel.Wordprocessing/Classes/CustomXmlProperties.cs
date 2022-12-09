namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public class CustomXmlPropertiesImpl: ModelElementImpl, CustomXmlProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlPlaceholder>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlPlaceholder>();
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
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.CustomXmlPlaceholder{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Collection<CustomXmlAttribute>? CustomXmlAttributes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

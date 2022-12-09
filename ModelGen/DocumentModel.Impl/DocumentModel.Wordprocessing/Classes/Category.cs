namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public class CategoryImpl: ModelElementImpl, Category
{
  public DocumentFormat.OpenXml.Wordprocessing.Category? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Category?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Name != null)
        {
          if (value is not null)
            OpenXmlElement.Name.Val = (System.String?)value;
          else
            OpenXmlElement.Name = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Name = new DocumentFormat.OpenXml.Wordprocessing.Name{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
        return (DocPartGalleryKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Gallery>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Gallery{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public partial class CategoryImpl: ModelElementImpl, Category
{
  public DocumentFormat.OpenXml.Wordprocessing.Category? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Category?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CategoryImpl(): base() {}
  
  public CategoryImpl(DocumentFormat.OpenXml.Wordprocessing.Category openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Val?.Value;
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
  public DocumentModel.Wordprocessing.DocPartGalleryKind? Gallery
  {
    get => (DocumentModel.Wordprocessing.DocPartGalleryKind?)OpenXmlElement?.Gallery?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Gallery != null)
        {
          if (value is not null)
            OpenXmlElement.Gallery.Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues?)value;
          else
            OpenXmlElement.Gallery = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Gallery = new DocumentFormat.OpenXml.Wordprocessing.Gallery{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues?)value };
        }
      }
    }
  }
  
}

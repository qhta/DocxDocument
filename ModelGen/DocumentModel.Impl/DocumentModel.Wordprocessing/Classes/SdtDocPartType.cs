namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartTypeImpl: ModelElementImpl, SdtDocPartType
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtDocPartTypeImpl(): base() {}
  
  public SdtDocPartTypeImpl(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public virtual String? DocPartGallery
  {
    get => (System.String?)OpenXmlElement?.DocPartGallery?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DocPartGallery != null)
        {
          if (value is not null)
            OpenXmlElement.DocPartGallery.Val = (System.String?)value;
          else
            OpenXmlElement.DocPartGallery = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DocPartGallery = new DocumentFormat.OpenXml.Wordprocessing.DocPartGallery{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public virtual String? DocPartCategory
  {
    get => (System.String?)OpenXmlElement?.DocPartCategory?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DocPartCategory != null)
        {
          if (value is not null)
            OpenXmlElement.DocPartCategory.Val = (System.String?)value;
          else
            OpenXmlElement.DocPartCategory = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DocPartCategory = new DocumentFormat.OpenXml.Wordprocessing.DocPartCategory{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public virtual Boolean? DocPartUnique
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DocPartUnique();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}

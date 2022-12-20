namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public partial class SectionPropertiesChangeImpl: ModelElementImpl, SectionPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SectionPropertiesChangeImpl(): base() {}
  
  public SectionPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousSectionProperties? PreviousSectionProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PreviousSectionPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PreviousSectionPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TrackChangeType Class.
/// </summary>
public class TrackChangeTypeImpl: ModelElementImpl, TrackChangeType
{
  public DocumentFormat.OpenXml.Office2010.Word.TrackChangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.TrackChangeType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TrackChangeTypeImpl(): base() {}
  
  public TrackChangeTypeImpl(DocumentFormat.OpenXml.Office2010.Word.TrackChangeType openXmlElement): base(openXmlElement)
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
  
}

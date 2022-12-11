namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public class RunTrackChangeTypeImpl: ModelElementImpl, RunTrackChangeType
{
  public DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunTrackChangeTypeImpl(): base() {}
  
  public RunTrackChangeTypeImpl(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (String?)OpenXmlElement?.Author?.Value;
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
    get => (DateTime?)OpenXmlElement?.Date?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public partial class RunTrackChangeTypeImpl: ModelElementImpl, RunTrackChangeType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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

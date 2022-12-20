namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public partial class RunTrackChangeType2Impl: ModelElementImpl, RunTrackChangeType2
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RunTrackChangeType2Impl(): base() {}
  
  public RunTrackChangeType2Impl(DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType openXmlElement): base(openXmlElement)
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

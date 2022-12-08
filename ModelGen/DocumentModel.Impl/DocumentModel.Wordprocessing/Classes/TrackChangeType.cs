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
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}

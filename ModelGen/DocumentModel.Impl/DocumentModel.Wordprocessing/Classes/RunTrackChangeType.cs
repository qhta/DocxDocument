namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public class RunTrackChangeTypeImpl: ModelElementImpl, RunTrackChangeType
{
  public DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType?)_OpenXmlElement;
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

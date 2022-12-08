namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public class NoLineBreaksBeforeKinsokuImpl: ModelElementImpl, NoLineBreaksBeforeKinsoku
{
  public DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}

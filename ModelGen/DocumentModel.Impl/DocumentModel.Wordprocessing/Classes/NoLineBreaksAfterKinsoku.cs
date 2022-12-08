namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set of Characters Which Cannot End a Line.
/// </summary>
public class NoLineBreaksAfterKinsokuImpl: ModelElementImpl, NoLineBreaksAfterKinsoku
{
  public DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku?)_OpenXmlElement;
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

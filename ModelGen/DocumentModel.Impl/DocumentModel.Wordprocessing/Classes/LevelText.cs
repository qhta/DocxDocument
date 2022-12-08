namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public class LevelTextImpl: ModelElementImpl, LevelText
{
  public DocumentFormat.OpenXml.Wordprocessing.LevelText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LevelText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Level Text
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public Boolean? Null
  {
    get;
    set;
  }
  
}

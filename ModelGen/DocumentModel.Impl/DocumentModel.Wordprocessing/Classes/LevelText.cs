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
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public Boolean? Null
  {
    get => (Boolean?)OpenXmlElement?.Null?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Null = (System.Boolean?)value;
    }
  }
  
}

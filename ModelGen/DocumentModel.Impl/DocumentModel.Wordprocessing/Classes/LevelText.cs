namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public partial class LevelTextImpl: ModelElementImpl, LevelText
{
  public DocumentFormat.OpenXml.Wordprocessing.LevelText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LevelText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LevelTextImpl(): base() {}
  
  public LevelTextImpl(DocumentFormat.OpenXml.Wordprocessing.LevelText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Level Text
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Null?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Null = (System.Boolean?)value;
    }
  }
  
}

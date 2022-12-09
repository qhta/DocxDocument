namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public class DocGridImpl: ModelElementImpl, DocGrid
{
  public DocumentFormat.OpenXml.Wordprocessing.DocGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocGrid?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocGridKind? Type
  {
    get => (DocGridKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.DocGridValues?)value;
    }
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  public Int32? LinePitch
  {
    get => (Int32?)OpenXmlElement?.LinePitch?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LinePitch = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  public Int32? CharacterSpace
  {
    get => (Int32?)OpenXmlElement?.CharacterSpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CharacterSpace = (System.Int32?)value;
    }
  }
  
}

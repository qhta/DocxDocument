namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public partial class DocGridImpl: ModelElementImpl, DocGrid
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DocGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocGrid?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocGridImpl(): base() {}
  
  public DocGridImpl(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocumentModel.Wordprocessing.DocGridKind? Type
  {
    get => (DocumentModel.Wordprocessing.DocGridKind?)OpenXmlElement?.Type?.Value;
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
    get => (System.Int32?)OpenXmlElement?.LinePitch?.Value;
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
    get => (System.Int32?)OpenXmlElement?.CharacterSpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CharacterSpace = (System.Int32?)value;
    }
  }
  
}

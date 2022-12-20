namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public partial class StyleSetImpl: ModelElementImpl, StyleSet
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.StyleSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.StyleSet?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StyleSetImpl(): base() {}
  
  public StyleSetImpl(DocumentFormat.OpenXml.Office2010.Word.StyleSet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? Val
  {
    get => (DocumentModel.Wordprocessing.OnOffKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
    }
  }
  
}

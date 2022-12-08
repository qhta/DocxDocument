namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public class StyleSetImpl: ModelElementImpl, StyleSet
{
  public DocumentFormat.OpenXml.Office2010.Word.StyleSet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.StyleSet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Val
  {
    get => (OnOffKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
    }
  }
  
}

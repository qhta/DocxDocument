namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public partial class BreakImpl: ModelElementImpl, Break
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Break?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BreakImpl(): base() {}
  
  public BreakImpl(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Break Type
  /// </summary>
  public DocumentModel.Wordprocessing.BreakKind? Type
  {
    get => (DocumentModel.Wordprocessing.BreakKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.BreakValues?)value;
    }
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public DocumentModel.Wordprocessing.BreakTextRestartLocationKind? Clear
  {
    get => (DocumentModel.Wordprocessing.BreakTextRestartLocationKind?)OpenXmlElement?.Clear?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Clear = (DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues?)value;
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public class BreakImpl: ModelElementImpl, Break
{
  public DocumentFormat.OpenXml.Wordprocessing.Break? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Break?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BreakImpl(): base() {}
  
  public BreakImpl(DocumentFormat.OpenXml.Wordprocessing.Break openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Break Type
  /// </summary>
  public BreakKind? Type
  {
    get => (BreakKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.BreakValues?)value;
    }
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public BreakTextRestartLocationKind? Clear
  {
    get => (BreakTextRestartLocationKind?)OpenXmlElement?.Clear?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Clear = (DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues?)value;
    }
  }
  
}

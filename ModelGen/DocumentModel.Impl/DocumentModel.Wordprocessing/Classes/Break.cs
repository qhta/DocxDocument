namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public class BreakImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Break>, Break
{
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

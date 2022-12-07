namespace DocumentModel.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public class TabStopImpl: ModelElement<DocumentFormat.OpenXml.Drawing.TabStop>, TabStop
{
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public TextTabAlignmentKind? Alignment
  {
    get => (TextTabAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues?)value;
    }
  }
  
}

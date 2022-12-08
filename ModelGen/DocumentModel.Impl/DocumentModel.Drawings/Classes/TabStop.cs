namespace DocumentModel.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public class TabStopImpl: ModelElementImpl, TabStop
{
  public DocumentFormat.OpenXml.Drawing.TabStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TabStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Tab Position
  /// </summary>
  public Int32? Position
  {
    get;
    set;
  }
  
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

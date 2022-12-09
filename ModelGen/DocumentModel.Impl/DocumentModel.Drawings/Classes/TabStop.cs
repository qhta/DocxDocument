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
    get => (Int32?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.Int32?)value;
    }
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

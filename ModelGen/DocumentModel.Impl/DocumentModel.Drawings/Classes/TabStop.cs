namespace DocumentModel.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public partial class TabStopImpl: ModelElementImpl, TabStop
{
  public DocumentFormat.OpenXml.Drawing.TabStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TabStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TabStopImpl(): base() {}
  
  public TabStopImpl(DocumentFormat.OpenXml.Drawing.TabStop openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Tab Position
  /// </summary>
  public Int32? Position
  {
    get => (System.Int32?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public DocumentModel.Drawings.TextTabAlignmentKind? Alignment
  {
    get => (DocumentModel.Drawings.TextTabAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues?)value;
    }
  }
  
}

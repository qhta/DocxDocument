namespace DocumentModel.Drawings;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public partial class RelativeOffsetImpl: ModelElementImpl, RelativeOffset
{
  public DocumentFormat.OpenXml.Drawing.RelativeOffset? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.RelativeOffset?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RelativeOffsetImpl(): base() {}
  
  public RelativeOffsetImpl(DocumentFormat.OpenXml.Drawing.RelativeOffset openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Offset X
  /// </summary>
  public Int32? OffsetX
  {
    get => (System.Int32?)OpenXmlElement?.OffsetX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OffsetX = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public Int32? OffsetY
  {
    get => (System.Int32?)OpenXmlElement?.OffsetY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OffsetY = (System.Int32?)value;
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public class ShadowImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Shadow>, Shadow
{
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}

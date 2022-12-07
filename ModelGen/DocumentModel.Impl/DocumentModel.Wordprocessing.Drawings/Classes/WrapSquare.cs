namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Square Wrapping.
/// </summary>
public class WrapSquareImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>, WrapSquare
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText
  {
    get => (WrapTextKind?)OpenXmlElement?.WrapText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapText = (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues?)value;
    }
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}

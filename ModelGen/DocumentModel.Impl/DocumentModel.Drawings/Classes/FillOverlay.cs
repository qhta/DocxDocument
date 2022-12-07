namespace DocumentModel.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public class FillOverlayImpl: ModelElement<DocumentFormat.OpenXml.Drawing.FillOverlay>, FillOverlay
{
  /// <summary>
  /// Blend
  /// </summary>
  public BlendMode? Blend
  {
    get => (BlendMode?)OpenXmlElement?.Blend?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Blend = (DocumentFormat.OpenXml.Drawing.BlendModeValues?)value;
    }
  }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public BlipFill1? BlipFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
}

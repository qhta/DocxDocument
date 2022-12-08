namespace DocumentModel.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public class FillOverlayImpl: ModelElementImpl, FillOverlay
{
  public DocumentFormat.OpenXml.Drawing.FillOverlay? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FillOverlay?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// NoFill.
  /// </summary>
  public Boolean? NoFill
  {
    get;
    set;
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
  public BlipFill2? BlipFill
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
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public Boolean? GroupFill
  {
    get;
    set;
  }
  
}

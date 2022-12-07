namespace DocumentModel.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public class BlendImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Blend>, Blend
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public BlendMode? BlendMode
  {
    get => (BlendMode?)OpenXmlElement?.BlendMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlendMode = (DocumentFormat.OpenXml.Drawing.BlendModeValues?)value;
    }
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public EffectContainer? EffectContainer
  {
    get;
    set;
  }
  
}

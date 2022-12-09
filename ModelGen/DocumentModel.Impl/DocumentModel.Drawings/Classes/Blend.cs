namespace DocumentModel.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public class BlendImpl: ModelElementImpl, Blend
{
  public DocumentFormat.OpenXml.Drawing.Blend? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Blend?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

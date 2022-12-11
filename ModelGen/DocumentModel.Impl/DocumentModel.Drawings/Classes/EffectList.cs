namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public class EffectListImpl: ModelElementImpl, EffectList
{
  public DocumentFormat.OpenXml.Drawing.EffectList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectListImpl(): base() {}
  
  public EffectListImpl(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blur Effect.
  /// </summary>
  public Blur? Blur
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  public FillOverlay? FillOverlay
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Glow.
  /// </summary>
  public Glow? Glow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  public InnerShadow? InnerShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  public OuterShadow? OuterShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  public PresetShadow? PresetShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  public Reflection? Reflection
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public SoftEdge? SoftEdge
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
